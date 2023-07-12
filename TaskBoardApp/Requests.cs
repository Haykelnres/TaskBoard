using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardApp
{
    public class Requests
    {
        public static string fulldatarequest1 = "select taskData.taskID,taskData.taskName,specificTasks.specificTasksName," +
           "specificTasks.specificTasksWorkerName,specificTasks.specificTasksDateOfStart,specificTasks.specificTasksDateOfActualEnd," +
           "specificTasks.specificTasksDateOfEnd,specificTasks.specificTasksStatus,specificTasks.specificTasksCommentary," +
           "specificTasks.specificTasksWarn\r\nfrom taskData join specificTasks on taskData.taskID=specificTasks.taskID ";
        
    }

}
