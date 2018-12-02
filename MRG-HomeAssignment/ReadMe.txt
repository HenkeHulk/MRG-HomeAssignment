Install DB

1. Change connection string in appconfig file MRG-HomeAssignment.Lib and webconfig file in MRG-HomeAssignment.WebUI

<connectionStrings>
    <add name="UserDB"
    connectionString="Data Source=YourComputername\SqlIntanceName;Initial Catalog=UserDB;Integrated Security=true"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>

2. Create Database from package manager console:
update-database -projectname MRG-HomeAssignment.Lib