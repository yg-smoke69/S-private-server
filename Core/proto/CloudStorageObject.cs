using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014F2")]
public class CloudStorageObject
{
	[Token(Token = "0x4009056")]
	[FieldOffset(Offset = "0x8")]
	public ECloudStorage.ObjectType object_type;

	[Token(Token = "0x4009057")]
	[FieldOffset(Offset = "0xC")]
	public string object_name;

	[Token(Token = "0x4009058")]
	[FieldOffset(Offset = "0x10")]
	public ulong object_length;

	[Token(Token = "0x4009059")]
	[FieldOffset(Offset = "0x18")]
	public string object_upload_url;

	[Token(Token = "0x6007B41")]
	[Address(RVA = "0x309CBC8", Offset = "0x309CBC8", VA = "0x309CBC8")]
	public CloudStorageObject()
	{
	}
}
