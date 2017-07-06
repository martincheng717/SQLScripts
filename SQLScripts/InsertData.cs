using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScripts
{
    class InsertData
    {
    //        IF NOT EXISTS(SELECT* FROM ApplicationConfiguration WHERE ApplicationKey = 3906 AND configurationname = 'FeatureIntuit')
    // BEGIN
    //  INSERT INTO ApplicationConfiguration(ApplicationKey, ConfigurationName, ConfigurationValue, CreateDate, ChangeDate, ChangeBy)
    //   VALUES(3906,'FeatureIntuit', '', GETDATE(), GETDATE(), SUSER_SNAME())
    // END
    //ELSE
    // BEGIN
    //  UPDATE ApplicationConfiguration SET ConfigurationValue = '', CHANGEDATE = getdate(), CHANGEBY = SUSER_SNAME()
    //   WHERE ApplicationKey = 3906 AND ConfigurationName = 'FeatureIntuit'
    //END
    }
}
