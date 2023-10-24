namespace ComputopRequestTest.Presentation.Contracts
{
    public record GetParametersResponse(
        IReadOnlyList<Parameter> Parameters
        );
}