using System.Drawing;
using System.Threading.Tasks.Dataflow;
using System.Timers;
using ligaBetplay.constructores;
using ligaBetplay.crud;
using ligaBetplay.menus;
using ligaBetplay.resources;

namespace ligaBetPlayDOTNET.crud
{
    public class CrudStaff
    {
        public static void AgregarStaff() {
            Console.Clear();
            CrudEquipos.VerEquipos();
            Console.WriteLine("Por favor, ingrese el nombre del equipo al cual va a pertenecer el miembro del staff: ");
            string NombreEquipo = Console.ReadLine();
            bool EquipoExiste = Utils.ValidarNombreEquipo(NombreEquipo);

            if(EquipoExiste){
                string IdEquipo = (from equipo in MenusGenerales.ContenedorGeneral
                                  where equipo.nombre == NombreEquipo select equipo.id).FirstOrDefault();
                Console.WriteLine("Por favor, ingrese el nombre del miembro del Staff: ");
                string NombreStaff = Console.ReadLine();
                Console.WriteLine("Por favor, ingrese el apellido del miembro del Staff: ");
                string ApellidoStaff = Console.ReadLine();
                Console.WriteLine("Por favor, ingrese el rol del miembro del staff:");
                string RolStaff = Console.ReadLine();
                string StaffId = Guid.NewGuid().ToString();
                Staff StaffMember = new Staff(StaffId, NombreStaff, ApellidoStaff, RolStaff, IdEquipo);
                MenusGenerales.ContenedorStaff.Add(StaffMember);
                Console.WriteLine("El miembro del staff fue agregado correctamente");
            } else {
                Console.WriteLine("El Equipo no pudo ser encontrado. Por favor, vuelva a intentarllo.");
                Console.ReadKey(true);
                AgregarStaff();

            }
            
        
        }

        public static void VerStaff(){
            Console.Clear();
            Console.WriteLine("Los miembros disponibles en el staff son: ");
            foreach (var miembro in MenusGenerales.ContenedorStaff)
            {
                Console.WriteLine($"Id Miembro {miembro.Id}// Nombre: {miembro.Nombre} // Apellido: {miembro.Apellido} // Rol: {miembro.rol}");
            }
        }

        public static void EditarStaff(){
            Console.Clear();
            VerStaff();
            Console.WriteLine("ingrese el id del miembro del staff que quiere editar:");
            string MiembroElegido = Console.ReadLine();
            bool MiembroExiste = Utils.ValidarIdStaff(MiembroElegido);
            if(MiembroExiste){
                Console.WriteLine("Por favor, ingrese el nuevo nombre del miembro del Staff: ");
                string NuevoNombre =Console.ReadLine();
                Console.WriteLine("Por favor, ingrese el nuevo apellido del miembro del staff:");
                string NuevoApellido = Console.ReadLine();
                Console.WriteLine("Por Favor, ingrese el nuevo rol del mimebro del staff.");
                string NuevoRol = Console.ReadLine();
                foreach (var member in MenusGenerales.ContenedorStaff)
                {
                    if(member.Id==MiembroElegido){
                        member.Nombre=NuevoNombre;
                        member.Apellido = NuevoApellido;
                        member.rol = NuevoRol;
                        Console.WriteLine("El miembro del staff pudo ser actualizado con éxito. Presione enter para continuar.");
                        Console.ReadKey(true);
                    }
                }
            } else {
                Console.WriteLine("El miembro no existe. Presione enter para volver a intentarlo.");
                Console.ReadKey(true);
            }
        }

        public static void EliminarStaff(){
            Console.Clear();
            VerStaff();
            Console.WriteLine("Por favor, digite el id del miembro del staff que desea modificar");
            string MiembroElegido = Console.ReadLine();
            bool MiembroExiste = Utils.ValidarIdStaff(MiembroElegido);
            if(MiembroExiste){
                foreach (var miembro in MenusGenerales.ContenedorStaff)
                {
                    if(miembro.Id == MiembroElegido){
                        MenusGenerales.ContenedorStaff.Remove(miembro);
                        Console.WriteLine("El miembro ha sido borrado con éxito. Por favor, presione enter para continuar");
                        Console.ReadKey(true);
                    } 
                } 
            }
        }
    }
}