Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO



Module mdlPrincipal
    Public CadenaDeConexion As String = "Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true"

    Public directorioLocal As String = getLocalPath()


    Public Function getLocalPath() As String
        getLocalPath = Path.GetDirectoryName(Application.StartupPath)
        getLocalPath = getLocalPath.Substring(0, getLocalPath.Length - 3)
        Return getLocalPath
    End Function


End Module
