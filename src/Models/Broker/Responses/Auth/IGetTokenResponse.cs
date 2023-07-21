namespace LT.DigitalOffice.Models.Broker.Responses.Auth;

public interface IGetTokenResponse
{
  string AccessToken { get; }
  string RefreshToken { get; }
  double AccessTokenExpiresIn { get; }
  double RefreshTokenExpiresIn { get; }

  static object CreateObj(
      string accessToken,
      string refreshToken,
      double accessTokenExpiresIn,
      double refreshTokenExpiresIn)
  {
    return new
    {
      AccessToken = accessToken,
      RefreshToken = refreshToken,
      AccessTokenExpiresIn = accessTokenExpiresIn,
      RefreshTokenExpiresIn = refreshTokenExpiresIn
    };
  }
}
