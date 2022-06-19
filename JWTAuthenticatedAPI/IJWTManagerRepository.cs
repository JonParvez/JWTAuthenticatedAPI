namespace JWTAuthenticatedAPI
{
	public interface IJWTManagerRepository
	{
		Tokens Authenticate(Users users);
	}
}
