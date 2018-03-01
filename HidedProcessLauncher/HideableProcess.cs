using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HidedProcessLauncher
{
  /// <summary>
  /// Custom class inhertited of Process
  /// </summary>
  class HideableProcess : Process
  {
    /// <summary>
    /// Enum of states
    /// </summary>
    enum States
    {
      Visible,
      Hided
    }
    /// <summary>
    /// State of the window
    /// </summary>
    States m_State;
    /// <summary>
    /// MainWindowHandle
    /// </summary>
    IntPtr m_WindowHandle = IntPtr.Zero;

    /// <summary>
    /// Member that says if the process is hideable
    /// </summary>
    bool m_bHideable;

    /// <summary>
    /// Property that says if the process is hideable
    /// </summary>
    public bool IsHideable
    {
      get
      {
        return m_bHideable;
      }
    }

    /// <summary>
    /// Constructor of the class
    /// </summary>
    public HideableProcess()
    {
      m_State = States.Visible;
    }

    /// <summary>
    /// Togle the visibility of the process
    /// </summary>
    public void TogleState()
    {
      if (m_State == States.Visible)
      {
        WindowAPI.HideMainWindow(m_WindowHandle);
        m_State = States.Hided;
      }
      else if (m_State == States.Hided)
      {
        WindowAPI.ShowMainWindow(m_WindowHandle);
        m_State = States.Visible;
      }
    }
    /// <summary>
    /// Show the MainWindow
    /// </summary>
    public void Show()
    {
      if (m_State == States.Hided)
      {
        WindowAPI.ShowMainWindow(m_WindowHandle);
        m_State = States.Visible;
      }
    }
    /// <summary>
    /// Hide the MainWindow
    /// </summary>
    public void Hide()
    {
      if (m_State == States.Visible)
      {
        WindowAPI.HideMainWindow(m_WindowHandle);
        m_State = States.Hided;
      }
    }

    /// <summary>
    /// Start the Process
    /// </summary>
    /// <returns></returns>
    public new async Task Start()
    {

      base.Start();
      try
      {
        //Wait for procces start
        Thread.Sleep(1500);

        //Wait for procces InputIdle
        int nWaitTime = 30000;
        if (base.WaitForInputIdle(nWaitTime))
        {
          m_WindowHandle = MainWindowHandle;
          m_bHideable = true;
        }
        else
        {
          //The process doesn't make WindowHandle in nWaitTime so we don't manage it
          m_bHideable = false;
        }
      }
      catch (Exception ex)
      {
        //if the process doesn't have GUI, the code throws exception, so we take the handle and compare it with IntPtr.Zero
        //if WindowHandle == IntPtr.Zero the process is not hideable
        //else if WindowHandle != IntPtr.Zero  the process is hideable
        m_WindowHandle = MainWindowHandle;
        m_bHideable = m_WindowHandle != IntPtr.Zero;
      }
    }

  }
}
