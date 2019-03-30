using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormThreadingTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {      
      InitializeComponent();
      btnStartProcess.Enabled = true;
    }
    private int updateRecCountOnProcessMovementForm(int recCount)
    {
      this.Invoke((Action)(() =>
      {
        lblRecordsProcessed.Text = String.Format("{0} has processed", recCount);
        //txtEndTime.Text = System.DateTime.Now.ToString();
        var workStartDate = new DateTime(2010, 5, 1);
        var workEndDate1 = new DateTime(2013, 6, 1);
        var months2800 = (int)workEndDate1.Subtract(workStartDate).Days / 30;
        var workEndDate2 = new DateTime(2016, 5, 1);
        var months4200_0 = (int)workEndDate2.Subtract(workEndDate1).Days / 30;
        var workEndDate3 = new DateTime(2017, 1, 1);
        var months1600 = (int)workEndDate3.Subtract(workEndDate2).Days / 30;
        var workEndDate4 = new DateTime(2017, 5, 1);
        var months4200_1 = (int)workEndDate4.Subtract(workEndDate3).Days / 30;
        var workEndDate5 = new DateTime(2018, 6, 1);
        var months1600_1 = (int)workEndDate5.Subtract(workEndDate4).Days / 30;
        var workEndDate6 = new DateTime(2019, 1, 1);
        var months4200_2 = (int)workEndDate6.Subtract(workEndDate5).Days / 30;
        //txtEndTime.Text =System.DateTime.Now.ToString();
        txtEndTime.Text = ((months1600 + months1600_1) * 1600 + months2800 * 2800 + (months4200_0 + months4200_1 + months4200_2) * 4200).ToString();

        Refresh();
        Application.DoEvents();
      }));
      return recCount;
    }

    private async void btnStartProcess_Click(object sender, EventArgs e)
    {
      Refresh();
      Application.DoEvents();
      IList<Task> tasks = new List<Task>();
      #region container logic is run in async
      Task containerTask = new Task((obj) =>
      {
        for (int i = 0; i < 100; i++)
        {
          Task.Delay(500);
          Console.WriteLine("{0} -iteration task 1 - {1}", i, Thread.CurrentThread.ManagedThreadId);
        }
      }, null, CancellationToken.None, TaskCreationOptions.LongRunning);
      
        containerTask.Start(TaskScheduler.Default);
        tasks.Add(containerTask);
      
      #endregion
      
      Task processMain = new Task((obj) => Process(
           
            zupdateRecCountOnProcessMovementForm: updateRecCountOnProcessMovementForm), null, CancellationToken.None, TaskCreationOptions.LongRunning);
      processMain.Start(TaskScheduler.Default);
      tasks.Add(processMain);
      await Task.WhenAll(tasks.ToArray());
      txtEndTime.Text = System.DateTime.Now.ToString();
      


    }

    private void Process(Func<int, int> zupdateRecCountOnProcessMovementForm)
    {
      for (int i = 0; i < 10000; i++)
      {
        Task.Delay(500);
        Console.WriteLine("{0} -iteration task 2 - {1}", i, Thread.CurrentThread.ManagedThreadId);
        zupdateRecCountOnProcessMovementForm(i);
      }
    }
  }
}
