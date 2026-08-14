using Il2CppDummyDll;

[Token(Token = "0x20007A2")]
public class TriggerActionSpawnCollider : TriggerActionBase
{
	[Token(Token = "0x4004EE5")]
	[FieldOffset(Offset = "0x1C")]
	public uint MeshTemplateID;

	[Token(Token = "0x4004EE6")]
	[FieldOffset(Offset = "0x20")]
	public uint TriggerTemplateID;

	[Token(Token = "0x4004EE7")]
	[FieldOffset(Offset = "0x24")]
	public uint DisplayTemplateID;

	[Token(Token = "0x4004EE8")]
	[FieldOffset(Offset = "0x28")]
	public uint BatchID;

	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x263C338", Offset = "0x263C338", VA = "0x263C338")]
	public TriggerActionSpawnCollider()
	{
	}
}
