using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Data;
using System.ComponentModel;

public class Program
{
    static Dictionary<string, bool> dangerous_words = new Dictionary<string, bool>();


    public static void Main(string[] args)
    {

        
        /*

          Budoco injects a where clause into queries when the logged on user belongs to an
          organization and so is restricted to only issues associated with that organization.
          The injection logic works like this:

          First look for "hints" ORG_JOIN $AND_ORG or $WHERE_ORG.
          You will probably want to use these hints if your queries are complex, like, if they use subquiries.

          if missing, look for first occurence of "where" and first occurence of "order"

          if yes where and yes order, then inject before order WITH AND
              select ... where foo AND (org = N) order by bar

          if yes where and no  order, then inject at the end WITH AND
              select ... where foo AND (org = N) 

          if no  where and yes order, then inject before order WITH WHERE instead of AND
              select ... WHERE (org = N) order by bar

          if no  where and no  order, then inject at the end WITH WHERE instead of AND
              select ... WHERE (org = N)
          */
    }

    public static string enhance_sql_per_user(HttpContext context, string sql)
    {
        
        //int us_id = context.Session.GetInt32("us_id");
        //int us_organization = context.Session.GetInt32("us_organization");

        string modified_sql = sql.Replace("$ME", us_id.ToString());

        int pos = string.IndexOf($AndOrg

        return modified_sql;
    }
}

}




