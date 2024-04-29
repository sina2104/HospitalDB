using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqlHospital
{
    internal class RegisterDAO
    {
        internal void IActionResult()
        {
            ConnectionMultiplexer conn = ConnectionMultiplexer.Connect("redis-16810.c250.eu-central-1-1.ec2.redns.redis-cloud.com:16810,allowAdmin=true");
            var info = conn.GetServer(conn.GetEndPoints().First()).InfoRaw();

        }
    }
}
