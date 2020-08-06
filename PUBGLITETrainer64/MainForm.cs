using Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// PUBGLITE Trainer by:Skrixx68
namespace PUBGLITETrainer64
{
    public partial class MainForm : Form
    {
        cheat cheats = new cheat();
        curAddr curAddress = new curAddr();
        Mem meme = new Mem();

        public MainForm()
        {
            InitializeComponent();

        }

        private List<int> getpId()
        {
            //Dictionary<int, int> listDictionary = new Dictionary<int, int>();
            Process[] aProc = Process.GetProcessesByName("PUBGLite-Win64-Shipping");
            List<int> procID = new List<int>();
            foreach (Process proc in aProc)
            {
                procID.Add(proc.Id);
                
            }
            Console.Out.WriteLine(procID.Count());
            return procID;
        }

        private List<int> getParentID()
        {
            Process[] aProc = Process.GetProcessesByName("PUBGLite-Win64-Shipping");
            List<int> procID = new List<int>();
            foreach (Process proc in aProc)
            {
                procID.Add(Process.GetProcessById(proc.Id).Parent().Id);
            }
            return procID;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            int pId = 0;
            bool open = false;
            List<int> ProcPID = getpId();
            List<int> ProcparentPID = getParentID();
            int a = 0;
            if (ProcPID[0] == ProcparentPID[a])
              ProcPID.RemoveAt(0);
              else if (ProcPID[0] == ProcparentPID[a+1])
                ProcPID.RemoveAt(0);
            pId = ProcPID[0];
            pId = ProcPID.FirstOrDefault();
            open = meme.OpenProcess(pId);
            if (pId > 0)
            {
                MessageBox.Show("Process Opened successfully PID:" + pId);
                if (open == true && meme.isAdmin())
                {
                    ant_chkbox.Enabled = true;
                    jump_chkbox.Enabled = true;
                    norecoil_chkbox.Enabled = true;
                    speed_chkbox.Enabled = true;
                    noObj_chkbox.Enabled = true;
                    btn_Open.Hide();
                    label1.Visible = true;
                    label2.Visible = true;
                    antiban_btn.Visible = true;

                    ProcPID = null;
                    ProcparentPID = null;
                }
                
                else
                {
                    MessageBox.Show("Hack Error 404");
                }
            }

        }

        private void freezeVal(string adr , string type , string overwrite)
        {
            meme.writeMemory(adr, "bytes", overwrite);
        }
            

        private void ant_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ant_chkbox.Checked == true)
            {
                setCheat(cheats.ant, cheats.anton, curAddress.ant);

            }
            else if(ant_chkbox.Checked == false)
            {
                Console.Out.WriteLine(ant_chkbox.Checked.ToString() + " Turning Off");
                for (int i = 0; i < curAddress.antLST.Count; i++)
                {
                    Console.Out.WriteLine(curAddress.antLST[i].ToString());
                    meme.writeMemory(curAddress.antLST[i].ToString(), "bytes", cheats.antOri);
                    
                }
                curAddress.antLST = new ArrayList();
            }
        }

        private void norecoil_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (norecoil_chkbox.Checked == true)
            {
                setCheat(cheats.norecoil, cheats.norecoilOn, curAddress.recoil);

            }
            else if (norecoil_chkbox.Checked == false)
            {
                Console.Out.WriteLine(norecoil_chkbox.Checked.ToString() + " Turning Off");
                for (int i = 0; i < curAddress.recoilLST.Count; i++)
                {
                    Console.Out.WriteLine(curAddress.recoilLST[i].ToString());
                    meme.writeMemory(curAddress.recoilLST[i].ToString(), "bytes", cheats.norecoilOri);
                    
                }
                curAddress.recoilLST = new ArrayList();
            }
        }
        private void jump_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (jump_chkbox.Checked == true)
            {
                setCheat(cheats.jump, cheats.jumpOn , curAddress.jump);
            }
                else if (jump_chkbox.Checked == false)
                {
                    Console.Out.WriteLine(jump_chkbox.Checked.ToString() + " Turning Off hack");
                    for (int i = 0; i < curAddress.jumpLST.Count; i++)
                    {
                        Console.Out.WriteLine(curAddress.jumpLST[i].ToString());
                        meme.writeMemory(curAddress.jumpLST[i].ToString(), "bytes", cheats.jumpOri);
                    
                    }
                curAddress.jumpLST = new ArrayList();
            }
            
        }

        private void nograss_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nograss_chkbox.Checked == true)
            {
                if(curAddress.noGrassLST.Count >= 1)
                {
                    Console.Out.WriteLine(nograss_chkbox.Checked.ToString() + " Freezing hack");
                    while (nograss_chkbox.Checked == true)
                    {
                        for (int i = 0; i < curAddress.noGrassLST.Count; i++)
                        {
                            Console.Out.WriteLine(curAddress.noGrassLST[i].ToString());
                            freezeVal(curAddress.noGrassLST[i].ToString(), "bytes", cheats.grassOn);

                        }
                    }
                }
                else
                {
                    setCheat(cheats.grass, cheats.grassOn, 0);
                }

               
            }
            else
            {
                Console.Out.WriteLine(nograss_chkbox.Checked.ToString() + " Turning Off hack");
                for (int i = 0; i < curAddress.noGrassLST.Count; i++)
                {
                    Console.Out.WriteLine(curAddress.noGrassLST[i].ToString());
                    meme.writeMemory(curAddress.noGrassLST[i].ToString(), "bytes", cheats.grassOri);

                }
                //curAddress.jumpLST = new ArrayList();
            }
        }

        private void fog_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (fog_chkbox.Checked == true)
            {
                setCheat(cheats.fog, cheats.fogOn, 0);
            }
            else
            {

            }
        }

        private void noWater_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (noWater_chkbox.Checked == true)
            {
                setCheat(cheats.removeWater, cheats.removeWateron ,0);
            }
            else
            {

            }
        }

        private void speed_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (speed_chkbox.Checked == true)
            {
                setCheat(cheats.speed, cheats.speedOn, curAddress.speed);
            }
            else if (speed_chkbox.Checked == false)
            {
                Console.Out.WriteLine(speed_chkbox.Checked.ToString() + " Turning Off");
                for (int i = 0; i < curAddress.speedLST.Count; i++)
                {
                    Console.Out.WriteLine(curAddress.speedLST[i].ToString());
                    meme.writeMemory(curAddress.speedLST[i].ToString(), "bytes", cheats.speedOri);
                    
                }
                curAddress.speedLST = new ArrayList();
            }
        }

        private void driveText_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (driveText_chkbox.Checked == true)
            {
                setCheat(cheats.driveText, cheats.driveTextOn, 0);
            }
            else
            {

            }
        }

        private void whiteFloor_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteFloor_chkbox.Checked == true)
            {
                 setCheat(cheats.whiteflr, cheats.whiteflrOn, 0);
            }
            else
            {
            }
        }

        private void noObj_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (noObj_chkbox.Checked == true)
            {
                 setCheat(cheats.noObj, cheats.noObjOn, 0);
            }
            else
            {
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            MessageBox.Show("You Have Been IP banned");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                fog_chkbox.Enabled = true;
                nograss_chkbox.Enabled = true;
                noWater_chkbox.Enabled = true;
                driveText_chkbox.Enabled = true;
                whiteFloor_chkbox.Enabled = true;

            }
            else
            {
                fog_chkbox.Enabled = false;
                nograss_chkbox.Enabled = false;
                noWater_chkbox.Enabled = false;
                driveText_chkbox.Enabled = false;
                whiteFloor_chkbox.Enabled = false;
            }

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;

        }

        public void setCheat( string cheatPattern, string cheatOverride, int type)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                List<object> arguments = new List<object>();
                arguments.Add(cheatPattern);
                arguments.Add(cheatOverride);
                arguments.Add(type);
                backgroundWorker1.RunWorkerAsync(arguments);
            }
        }

        public Task<IEnumerable<long>> AoBScan(string search)
        {
            return meme.AoBScan(0x10000000000, 0x2FFFFFFFFFF,search, true, false);
        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<object> genericlist = e.Argument as List<object>;
            ////long startADDR = (long)genericlist[0];
            ////long endADDR = (long)genericlist[1];
            //string cheatPattern = genericlist[2].ToString();
            //string cheatOverride = genericlist[3].ToString();
            //int type = (int) genericlist[4];
            string cheatPattern = genericlist[0].ToString();
            string cheatOverride = genericlist[1].ToString();
            int type = (int)genericlist[2];

            backgroundWorker1.ReportProgress(30);
            if (backgroundWorker1.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                backgroundWorker1.ReportProgress(50);
                string address = "";
                string oldaddr = "";
                while (!address.Equals("0"))
                {
                    var res = AoBScan(cheatPattern);
                    address = res.Result.FirstOrDefault().ToString("x");
                    if (type == 1)
                    {
                        curAddress.recoilLST.Add(address);
                        oldaddr = oldaddr + "\n " + address.ToString();
                        
                    }
                    else if (type == 2)
                    {
                        curAddress.speedLST.Add(address);
                        oldaddr = oldaddr + "\n " + address.ToString();
                    }
                    else if (type == 3)
                    {
                        curAddress.jumpLST.Add(address);
                        oldaddr = oldaddr + "\n " + address.ToString();
                        
                    }
                    else if (type == 4)
                    {
                        curAddress.antLST.Add(address);
                        oldaddr = oldaddr + "\n " + address.ToString();
                    }
                    else if (type == 5)
                    {
                        curAddress.noGrassLST.Add(address);
                        oldaddr = oldaddr + "\n " + address.ToString();
                    }
                    meme.writeMemory(address, "bytes", cheatOverride);

                }
                MessageBox.Show("Done , Address = " + oldaddr.ToString());
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            label2.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                label1.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                label1.Text = "Error: " + e.Error.Message;
            }
            else
            {
                label2.Text = "Done!";
            }
        }


        private void antiban_btn_Click(object sender, EventArgs e)
        {
            string localTemp = Path.GetTempPath() + @"\reporter.exe";
            string shadowtracker = @"C:\Program Files (x86)\PUBGLite\Client\ShadowTrackerExtra\Binaries\ThirdParty\BroCrashReporter\BroCrashReporter.exe";
            string shadowtrackerextra = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ShadowTrackerExtra\Saved\Config\CrashReportClient";
            Console.Out.WriteLine(shadowtrackerextra + localTemp + shadowtracker);
            DirectoryInfo di = new DirectoryInfo(Path.GetTempPath());
            FileInfo[] files = di.GetFiles("*.dll")
                                 .Where(p => p.Extension == ".dll").ToArray();
            foreach (FileInfo file in files)
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                    Console.WriteLine(file.FullName);
                }
                catch { }

            if (File.Exists(localTemp))
            {
                File.Delete(localTemp);
            }

            if (File.Exists(shadowtracker))
            {
                File.Delete(shadowtracker);
            }

            DirectoryInfo directory = new DirectoryInfo(shadowtrackerextra);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }

            MessageBox.Show("Anti Ban Success");
        }
    }
}
public static class ProcessExtensions
{
    private static string FindIndexedProcessName(int pid)
    {
        var processName = Process.GetProcessById(pid).ProcessName;
        var processesByName = Process.GetProcessesByName(processName);
        string processIndexdName = null;

        for (var index = 0; index < processesByName.Length; index++)
        {
            processIndexdName = index == 0 ? processName : processName + "#" + index;
            var processId = new PerformanceCounter("Process", "ID Process", processIndexdName);
            if ((int)processId.NextValue() == pid)
            {
                return processIndexdName;
            }
        }

        return processIndexdName;
    }

    private static Process FindPidFromIndexedProcessName(string indexedProcessName)
    {
        var parentId = new PerformanceCounter("Process", "Creating Process ID", indexedProcessName);
        return Process.GetProcessById((int)parentId.NextValue());
    }

    public static Process Parent(this Process process)
    {
        return FindPidFromIndexedProcessName(FindIndexedProcessName(process.Id));
    }
}