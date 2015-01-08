using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;

namespace Hownet.BLL.BaseFile
{

        public static class HenqPost<T> where T : new()
        {
            /**/
            /// <summary>
            /// 为Model赋值
            /// </summary>
            /// <typeparam name="T">Model</typeparam>
            /// <param name="t">model</param>
            /// <param name="form">Request</param>
            /// <returns></returns>
            public static int GetPost<T>(ref T t, NameValueCollection form)
            {
                int va = 0;
                Type type = t.GetType();//获取类型
                PropertyInfo[] pi = type.GetProperties();//获取属性集合
                foreach (PropertyInfo p in pi)
                {
                    if (form[p.Name] != null)
                    {
                        try
                        {
                            p.SetValue(t, Convert.ChangeType(form[p.Name], p.PropertyType), null);//为属性赋值，并转换键值的类型为该属性的类型
                            va++;//记录赋值成功的属性数
                        }
                        catch
                        {
                        }
                    }
                }
                return va;
            }
        }
}