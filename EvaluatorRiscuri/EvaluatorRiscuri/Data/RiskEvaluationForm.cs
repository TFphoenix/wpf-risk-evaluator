using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluatorRiscuri.Models;

namespace EvaluatorRiscuri.Data
{
    public static class RiskEvaluationForm
    {
        // Evaluations
        public static List<FormItem> DATA_OPERATIONS_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Număr de personal implicat în operaţii cu date:",
                Weight = 1,
                Options = new []
                {
                    "Foarte mic (sub 2 persoane)",
                    "Mic (3-7 persoane)",
                    "Moderat (7-15 persoane)",
                    "Mare (16-25 persoane)",
                    "Foarte mare (peste 25)"
                }},
            new FormItem{
                Question = "Efectul în grupul de afacere:",
                Weight = 5,
                Options = new []
                {
                    "Nu are efect",
                    "Efect mic",
                    "Efect moderat",
                    "Efect mare",
                    "Evidenţiază afacerea"
                }},
            new FormItem{
                Question = "Numărul de aplicaţii:",
                Weight = 5,
                Options = new []
                {
                    "O singură aplicaţie",
                    "Sub 5 aplicaţii",
                    "Intre 5-15 aplicaţii",
                    "Intre 16-25 aplicaţii",
                    "Peste 25 aplicaţii"
                }},
            new FormItem{
                Question = "Numărul de utilizatori:",
                Weight = 2,
                Options = new []
                {
                    "Sub 25",
                    "Intre 25-50",
                    "Intre 51-100",
                    "Intre 100-250",
                    "Peste 250"
                }},
            new FormItem{
                Question = "Constatări prioritare ale auditului:",
                Weight = 1,
                Options = new []
                {
                    "Constatări nesemnificative",
                    "Constatări puţin semnificative",
                    "Constatări semnificative",
                    "Câteva constatări semnificative",
                    "Multe constatări semnificative"
                }},
            new FormItem{
                Question = "Complexitatea procesării datelor:",
                Weight = 2,
                Options = new []
                {
                    "Procesare în serie",
                    "Procesare în serie/timp-real",
                    "Procesare în serie/timp real/on-line",
                    "Procesare client-server",
                    "Procesare paralelă/distribuită"
                }},
            new FormItem{
                Question = "Schimbări în echipament/platformă/personal:",
                Weight = 1,
                Options = new []
                {
                    "Nu există schimbări",
                    "Schimpbări moderate/profit mic",
                    "Schimbări de platforme/profit mic",
                    "Profit mare",
                    "Schimbări de platforme şi profit mare"
                }},
            new FormItem{
                Question = "Număr de platforme (posturi de comandă):",
                Weight = 3,
                Options = new []
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5+"
                }},
        };

        public static List<FormItem> APPLICATIONS_SYSTEM_CREATION_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Efectul cedării sistemului (punctul critic):",
                Weight = 5,
                Options = new[]
                {
                    "Nici un efect imediat",
                    "Inconvenienţe pentru utilizatori",
                    "Pierderea înţelegerii",
                    "Pierdere de venit",
                    "Pierdere în afacere/venit/înţelegere"
                }},
            new FormItem{
                Question = "Expunerea financiară:",
                Weight = 5,
                Options = new[]
                {
                    "Nici o expunere",
                    "Expunere mică",
                    "Expunere moderată",
                    "Expunere mare",
                    "Expunere foarte mare"
                }},
            new FormItem{
                Question = "Expansiunea sistemului:",
                Weight = 2,
                Options = new[]
                {
                    "Este parte a unui departament",
                    "Reprezintă un departament complet",
                    "Reprezintă un departament multiplu",
                    "Cuprinde organizaţiaîn întregime",
                    "Organizaţie şi exterior"
                }},
            new FormItem{
                Question = "Vârsta aplicaţiei:",
                Weight = 1,
                Options = new[]
                {
                    "Sub 10 ani",
                    "7-10 ani",
                    "4-6 ani",
                    "1-3 ani",
                    "Mai puţin de un an"
                }},
            new FormItem{
                Question = "Constatări prioritare ale auditului:",
                Weight = 2,
                Options = new[]
                {
                    "Audit recent –fără puncte slabe",
                    "Audit recent –puţine puncte slabe",
                    "Audit –anumite puncte slabe",
                    "Audit –multe puncte slabe",
                    "Nici un audit anterior"
                }},
            new FormItem{
                Question = "Dimensiunea aplicaţiilor(număr de programme):",
                Weight = 3,
                Options = new[]
                {
                    "Sub 25",
                    "Intre 25-50",
                    "Intre 50-100",
                    "Intre 100-250",
                    "Peste 250"
                }},
            new FormItem{
                Question = "Modificări ale mediului/personalului:",
                Weight = 1,
                Options = new[]
                {
                    "Nu există modificări",
                    "Modificări moderate",
                    "Modificări semnificative",
                    "Modificări mari",
                    "Modificări semnificative şi profit mare"
                }},
            new FormItem{
                Question = "Număr de locaţii în care sunt implementate aplicaţiile:",
                Weight = 1,
                Options = new[]
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5+"
                }},
        };

        public static List<FormItem> APPLICATIONS_SYSTEM_DEVELOPMENT_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Dimensiunea, organizarea şi experienţa echipei de lucru:",
                Weight = 3,
                Options = new[]
                {
                    "Echipă mică, specializată şi experimentată",
                    "Echipă medie, organizare centralizată şi experimentată",
                    "Echipă medie, experimentată şi cu priorităţi mixte",
                    "Echipă medie, concetrată pe alte priorităţi",
                    "Echipă mare, descentralizată fără experienţă"
                }},
            new FormItem{
                Question = "Dimensiunea sistemului:",
                Weight = 3,
                Options = new[]
                {
                    "Număr mic de programe pentru un departament",
                    "Număr moderat de programe pentru un departament",
                    "Număr mare de programe pentru mai multe departamente",
                    "Număr moderat de programe  pentru întreaga organizaţie",
                    "Număr mare de programe pentru întreaga organizaţie"
                }},
            new FormItem{
                Question = "Durata ciclului de dezvoltare a sistemului:",
                Weight = 2,
                Options = new[]
                {
                    "Mai puţin de 3 luni",
                    "Intre 3-6 luni",
                    "Intre 6-12 luni",
                    "Intre 1-1 ½ ani",
                    "2 sau mai mulţi ani"
                }},
            new FormItem{
                Question = "Platforma de dezvoltare:",
                Weight = 3,
                Options = new[]
                {
                    "Verificată şi utilizată larg",
                    "Destul de nouă, dar acceptată universal",
                    "Destul de nouă, dar neacceptată universal",
                    "Verificată şi brevetată",
                    "Nouă, neverificată"
                }},
            new FormItem{
                Question = "Implicarea anterioară a auditului:",
                Weight = 2,
                Options = new[]
                {
                    "Controalele construiesc exerciţiile",
                    "Cerinţe de analiză pe faze",
                    "Monitorizare a planificării proiectului",
                    "Monitorizare a costului proiectului",
                    "Nici un fel de monitorizare"
                }},
            new FormItem{
                Question = "Metodologia de dezvoltare a sistemului:",
                Weight = 3,
                Options = new[]
                {
                    "Metodologie standard, documentată",
                    "Metodologie standard, nedocumentată",
                    "Metodologie non-standard, echipă experimentată",
                    "Metodologie experimentală, neverificată",
                    "Nu este utilizată o metodologie, standarde nedocumentate"
                }},
            new FormItem{
                Question = "Experienţă în managementul proiectelor:",
                Weight = 1,
                Options = new[]
                {
                    "Foarte mare",
                    "Peste medie",
                    "Medie",
                    "Sub medie",
                    "Fără experienţă"
                }},
            new FormItem{
                Question = "Mână de lucru externă:",
                Weight = 3,
                Options = new[]
                {
                    "Cantitate mică, 1 solicitare",
                    "Cantitate mică, solicitări diverse",
                    "Cantitate semnificativă, 1 solicitare",
                    "Cantitate semnificativă, solicitări diverse",
                    "100%"
                }},
        };

        public static List<FormItem> HUMAN_MATERIALS_RESOURCES_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Efect:",
                Weight = 5,
                Options = new[]
                {
                    "Nu are efect imediat",
                    "Inconvenienţe pentru utilizatori",
                    "Pierdere de profit",
                    "Pierdere de venit",
                    "Pierdere de afacere/venit/profit"
                }},
            new FormItem{
                Question = "Expunere financiară:",
                Weight = 5,
                Options = new[]
                {
                    "Nici una",
                    "Mică",
                    "Moderată",
                    "Mare",
                    "Foarte mare"
                }},
            new FormItem{
                Question = "Proceduri şi linii de ghidare:",
                Weight = 5,
                Options = new[]
                {
                    "Proceduri documentate şi testate",
                    "Proceduri nedocumentate",
                    "Proceduri neimplementate în întregime",
                    "Nu există proceduri, dar control da",
                    "Nu există proceduri şi nici control"
                }},
            new FormItem{
                Question = "Constatări prioritare ale auditului:",
                Weight = 2,
                Options = new[]
                {
                    "Audit recent –fără puncte slabe",
                    "Audit recent –minore puncte slabe",
                    "Audit –câteva puncte slabe",
                    "Audit –multe puncte slabe",
                    "Fără audit anterior"
                }},
            new FormItem{
                Question = "Complexitate:",
                Weight = 3,
                Options = new[]
                {
                    "Surse locale pentru un departament",
                    "Surse locale pentru întreaga organizaţie",
                    "Surse internaţionale pentru o tehnologie",
                    "Surse internaţionale pentru mai multe tehnologii",
                    "Surse  internationale  şi  locale  pentru  mai  multe tehnologii"
                }},
        };

        public static List<FormItem> SOFTWARE_ACQUISITION_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Scopul sistemului:",
                Weight = 5,
                Options = new[]
                {
                    "O parte din departament",
                    "Departamentul complet",
                    "Departamente multiple",
                    "Intreaga organizaţie",
                    "Organizaţia şi extern"
                }},
            new FormItem{
                Question = "Expunerea financiară:",
                Weight = 5,
                Options = new[]
                {
                    "Nici una",
                    "Mică",
                    "Moderată",
                    "Mare",
                    "Foarte mare"
                }},
            new FormItem{
                Question = "Natura pachetelor software:",
                Weight = 2,
                Options = new[]
                {
                    "Produse soft cu licenţă",
                    "Produse  soft  produse  de  vânzător  şi  întreţinute  de acesta",
                    "Produse  soft  produse  de  vânzător  şi  întreţinute  de unitate",
                    "Produse  soft  dezvoltate  în  comun  şi  întreţinute  de furnizor",
                    "Produse  soft  dezvoltate  în  comun  şi  întreţinute  de unitate"
                }},
            new FormItem{
                Question = "Tipul de evaluare:",
                Weight = 1,
                Options = new[]
                {
                    "De departamentul care utilizează/consultant/specialist",
                    "De utilizator/specialist",
                    "De consultant",
                    "De specialist",
                    "De utilizator"
                }},
            new FormItem{
                Question = "Costul şi complexitatea pachetului soft:",
                Weight = 2,
                Options = new[]
                {
                    "Neglijabil",
                    "Mic",
                    "Moderat",
                    "Semnificativ",
                    "Foarte mare"
                }},
            new FormItem{
                Question = "Metodologia de evaluare:",
                Weight = 3,
                Options = new[]
                {
                    "Evaluată de vânzător/producător",
                    "Evaluată de producător",
                    "Evaluată de furnizor",
                    "Neevaluată, cumpărată condiţionat",
                    "Neevaluata, cumpărată necondiţionat"
                }},
            new FormItem{
                Question = "Selecţiapachetelor soft:",
                Weight = 1,
                Options = new[]
                {
                    "Din mai multe candidate",
                    "De la câţiva vânzători cu reputaţie",
                    "Din câteva sisteme cunoscute",
                    "Alegerea unui sistem familiar",
                    "Alegerea unui sistem nefamiliar"
                }},
            new FormItem{
                Question = "Efectul în afacere:",
                Weight = 1,
                Options = new[]
                {
                    "Nu are efect imediat",
                    "Inconvenienţe pentru utilizatori",
                    "Pierdere de profit",
                    "Pierdere de venit",
                    "Pierdere de afacer/venit/profit"
                }},
        };

        public static List<FormItem> OTHER_FUNCTIONS_EVALUATION = new List<FormItem>
        {
            new FormItem{
                Question = "Efectul eşecului unei funcţii:",
                Weight = 5,
                Options = new[]
                {
                    "Nu are efect imedita",
                    "Inconvenienţe pentru utilizatori",
                    "Pierdere de beneficiu",
                    "Pierdere de venit",
                    "Pierdere de afacre/venit/profit"
                }},
            new FormItem{
                Question = "Expunere financiară:",
                Weight = 5,
                Options = new[]
                {
                    "Nici una",
                    "Mică",
                    "Moderată",
                    "Mare",
                    "Foarte mare"
                }},
            new FormItem{
                Question = "Scopul funcţiei:",
                Weight = 2,
                Options = new[]
                {
                    "O parte din departament",
                    "Departamentul complet",
                    "Departamente multiple",
                    "Intreaga organizaţie",
                    "Organizaţia şi exterior"
                }},
            new FormItem{
                Question = "Vârsta funcţiei:",
                Weight = 1,
                Options = new[]
                {
                    "Peste 10 ani",
                    "7-10 ani",
                    "4-6 ani",
                    "1-3 ani",
                    "Mai puţin de un an"
                }},
            new FormItem{
                Question = "Constatări anterioare ale auditului:",
                Weight = 2,
                Options = new[]
                {
                    "Audit recent –fără puncte slabe",
                    "Audit recent –puncte slabe minore",
                    "Fără audit anterior",
                    "Audit –câteva puncte slabe",
                    "Audit –multe puncte slabe"
                }},
            new FormItem{
                Question = "Complexitatea funcţiei:",
                Weight = 3,
                Options = new[]
                {
                    "Foarte mică",
                    "Mică",
                    "Moderată",
                    "Mare",
                    "Foarte mare"
                }},
            new FormItem{
                Question = "Număr de personal:",
                Weight = 1,
                Options = new[]
                {
                    "O persoană",
                    "Mai puţin de 5",
                    "Intre 6-10",
                    "Intre 11-25",
                    "Peste 25"
                }},
            new FormItem{
                Question = "Număr de locaţii:",
                Weight = 1,
                Options = new[]
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5+"
                }},
        };

        // Names
        public static Dictionary<List<FormItem>, string> EVALUATION_NAMES = new Dictionary<List<FormItem>, string>
        {
            {
                DATA_OPERATIONS_EVALUATION,
                "Evaluarea riscului S.I. –privind operaţiile centrate pe date"
            },
            {
                APPLICATIONS_SYSTEM_CREATION_EVALUATION,
                "Evaluarea riscului privind crearea sistemului de aplicaţii"
            },
            {
                APPLICATIONS_SYSTEM_DEVELOPMENT_EVALUATION,
                "Evaluarea  riscului –privind dezvoltarea sistemului de aplicaţii" },
            {
                HUMAN_MATERIALS_RESOURCES_EVALUATION,
                "Evaluarea riscurilor –privind obţinerea resurselor umane şi materiale" },
            {
                SOFTWARE_ACQUISITION_EVALUATION,
                "Evaluarea riscurilor privind achiziţiile de soft" },
            {
                OTHER_FUNCTIONS_EVALUATION,
                "Evaluarea riscului privind alte funcţii ale sistemelor informatice" }
        };
    }
}
