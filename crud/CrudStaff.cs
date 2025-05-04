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
    }
}