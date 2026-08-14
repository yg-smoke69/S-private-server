using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C09")]
public interface ITaggedData
{
	[Token(Token = "0x17001959")]
	short TagID
	{
		[Token(Token = "0x6017F90")]
		get;
	}

	[Token(Token = "0x6017F91")]
	void SetData(byte[] data, int offset, int count);

	[Token(Token = "0x6017F92")]
	byte[] GetData();
}
