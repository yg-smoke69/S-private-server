using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C9")]
public class CSSetVehicleDisplayReq
{
	[Token(Token = "0x4009447")]
	[FieldOffset(Offset = "0x8")]
	public uint vehicle_display_id;

	[Token(Token = "0x4009448")]
	[FieldOffset(Offset = "0xC")]
	public uint auto_rotate;

	[Token(Token = "0x6007C13")]
	[Address(RVA = "0x3099B68", Offset = "0x3099B68", VA = "0x3099B68")]
	public CSSetVehicleDisplayReq()
	{
	}
}
