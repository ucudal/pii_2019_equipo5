dotnet ef migrations add InitialCreate --context RazorPagesIgnisContext

dotnet aspnet-codegenerator razorpage -m Administrador -dc RazorPagesIgnisContext -udl -outDir Pages\administradores --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Cliente -dc RazorPagesIgnisContext -udl -outDir Pages\clientes --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Tecnico -dc RazorPagesIgnisContext -udl -outDir Pages\tecnicos --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Solicitud -dc RazorPagesIgnisContext -udl -outDir Pages\solicitudes --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m TecnicoSolicitud -dc RazorPagesIgnisContext -udl -outDir Pages\tecnicoSolicitudes --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Proyecto -dc RazorPagesIgnisContext -udl -outDir Pages\proyectos --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Rol -dc RazorPagesIgnisContext -udl -outDir Pages\roles --referenceScriptLibraries

dotnet ef migrations add Administrador --context RazorPagesIgnisContext
dotnet ef migrations add Cliente --context RazorPagesIgnisContext
dotnet ef migrations add Tecnico --context RazorPagesIgnisContext
dotnet ef migrations add Solicitud --context RazorPagesIgnisContext
dotnet ef migrations add TecnicoSolicitud --context RazorPagesIgnisContext
dotnet ef migrations add Proyecto --context RazorPagesIgnisContext
dotnet ef migrations add Rol --context RazorPagesIgnisContext
