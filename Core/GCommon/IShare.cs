using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200411F")]
public interface IShare
{
	[Token(Token = "0x601A9A2")]
	void BeforeScreenshot();

	[Token(Token = "0x601A9A3")]
	void AfterScreenshot();

	[Token(Token = "0x601A9A4")]
	void BeforeSharePreview();

	[Token(Token = "0x601A9A5")]
	void AfterSharePreview();

	[Token(Token = "0x601A9A6")]
	void OnShare(bool success, int platform);
}
