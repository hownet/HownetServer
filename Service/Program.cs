using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.Threading;
using System.ServiceModel.Channels;
using System.Windows.Forms;
using System.Diagnostics;

namespace Service
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //[STAThread]
            //static void Main()
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new ServiceForm());
            //}
            [STAThread]
            static void Main(string[] args)
            {
                if (args.Length == 0) //没有传送参数
                {
                    Process p = Service.SingleInstance.GetRunningInstance();
                    if (p != null) //已经有应用程序副本执行
                    {
                        Service.SingleInstance.HandleRunningInstance(p);
                    }
                    else //启动第一个应用程序
                    {
                        RunApplication();
                    }
                }
                else //有多个参数
                {
                    switch (args[0].ToLower())
                    {
                        case "-api":
                            if (Service.SingleInstance.HandleRunningInstance() == false)
                            {
                                RunApplication();
                            }
                            break;
                        case "-mutex":
                            if (args.Length >= 2) //参数中传入互斥体名称
                            {
                                if (Service.SingleInstance.CreateMutex(args[1]))
                                {
                                    RunApplication();
                                    Service.SingleInstance.ReleaseMutex();
                                }
                                else
                                {
                                    //调用SingleInstance.HandleRunningInstance()方法显示到前台。
                                    MessageBox.Show("程序已经运行！");
                                }
                            }
                            else
                            {
                                if (Service.SingleInstance.CreateMutex())
                                {
                                    RunApplication();
                                    Service.SingleInstance.ReleaseMutex();
                                }
                                else
                                {
                                    //调用SingleInstance.HandleRunningInstance()方法显示到前台。
                                    MessageBox.Show("程序已经运行！");
                                }
                            }
                            break;
                        case "-flag"://使用该方式需要在程序退出时调用
                            if (args.Length >= 2) //参数中传入运行标志文件名称
                            {
                                Service.SingleInstance.RunFlag = args[1];
                            }
                            try
                            {
                                if (Service.SingleInstance.InitRunFlag())
                                {
                                    RunApplication();
                                    Service.SingleInstance.DisposeRunFlag();
                                }
                                else
                                {
                                    //调用SingleInstance.HandleRunningInstance()方法显示到前台。
                                    MessageBox.Show("程序已经运行！");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        default:
                            MessageBox.Show("应用程序参数设置失败。");
                            break;
                    }
                }
            }
            static void RunApplication()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ServiceForm());
            }
            //Maticsoft.DBUtility.DbHelperSQL.connOpen();
            //try
            //{
            //    Console.WriteLine("正在启动服务....");
            //    ServiceHost serviceHost = new ServiceHost(typeof(FileTransportService));
            //    Console.WriteLine("宿主状态：" + serviceHost.State);
            //    serviceHost.Open();
            //    Console.WriteLine("宿主状态：" + serviceHost.State + "\r\n");
            //    Console.WriteLine("终结点列表：");
            //    for (int i = 0; i < serviceHost.Description.Endpoints.Count; i++)
            //    {
            //        Console.WriteLine(serviceHost.Description.Endpoints[i].Address);
            //    }
            //    Console.WriteLine("服务名称：" + serviceHost.Description.Name);
            //    Console.WriteLine("服务类型：" + serviceHost.Description.ServiceType);
            //    Console.WriteLine("服务类型：" + serviceHost.Description.ConfigurationName);
            //    Console.WriteLine("服务类型：" + serviceHost.Description.Behaviors);
            //    Console.WriteLine("服务已经启动，按任意键结束服务！");
            //    Console.ReadKey();
            //    serviceHost.Close();
            //    Console.WriteLine("宿主状态：" + serviceHost.State);
            //    Thread.Sleep(2000);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.ReadKey();
            //}
        }
    }
