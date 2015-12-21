using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;

namespace HappyWorkEveryday.Helper
{
    class Logger
    {
        private static string _errorLog;
        private static string _succLog;

        private static StorageFolder folder = ApplicationData.Current.LocalFolder;
        private static StorageFolder succlogFolder;
        private static StorageFolder errlogFolder;

        private static SemaphoreSlim obj = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Need call it when the app is initilized.
        /// </summary>
        public static async void CreateLog()
        {
            //Success folder
            try
            {
                succlogFolder = await folder.GetFolderAsync("succlog");
            }
            catch(FileNotFoundException e)
            {
                succlogFolder = await folder.CreateFolderAsync("succlog");
                WriteLogInfo(true, "创建SuccLog文件夹");
            }
            //Error folder
            try
            {
                errlogFolder = await folder.GetFolderAsync("errlog");
            }
            catch (FileNotFoundException e)
            {
                errlogFolder = await folder.CreateFolderAsync("errlog");
                WriteLogInfo(false, "创建ErrLog文件夹");
            }
        }

        public static async void WriteLogInfo(bool flag, Exception e)
        {
            await obj.WaitAsync();
            try
            {
                StorageFile file = await CreateFile(flag);
                await FileIO.AppendTextAsync(file, DateTime.Now.ToString("yyyyMMddmmss") + " " + e.HResult + " " + e.Message + "\r\n");
            }
            finally
            {
                obj.Release();
            }
        }

        public static async void WriteLogInfo(bool flag, string message)
        {
            await obj.WaitAsync();
            try
            {
                StorageFile file = await CreateFile(flag);
                Debug.WriteLine(message);
                await FileIO.AppendTextAsync(file, DateTime.Now.ToString("yyyyMMddmmss") + " " + message + "\r\n");
            }
            finally
            {
                obj.Release();
            }
        }

        public static async Task<StorageFile> CreateFile(bool flag)
        {
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".log";
            StorageFile sampleFile;
            if (flag)
            {
                sampleFile = await succlogFolder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
            }
            else
            {
                sampleFile = await errlogFolder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
            }
            

            return sampleFile;
        }
    }
}
