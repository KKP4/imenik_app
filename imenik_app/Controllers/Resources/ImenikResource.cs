using FluentValidation;

namespace imenik.Controllers.Resources
{ 
    public class KontaktResources
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public string TelStevilka { get; set; }
    }

    public class KontaktValidator : AbstractValidator<KontaktResources>
    {
        public KontaktValidator()
        {
            RuleFor(kontakt => kontakt.Ime).NotEmpty();
            RuleFor(kontakt => kontakt.Priimek).NotNull();
            RuleFor(kontakt => kontakt.Naslov).NotNull();
            RuleFor(kontakt => kontakt.TelStevilka).NotNull().MinimumLength(9).MaximumLength(13);
        }
    }
}