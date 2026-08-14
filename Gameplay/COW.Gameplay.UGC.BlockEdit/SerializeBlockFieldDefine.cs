using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B97")]
public class SerializeBlockFieldDefine : BlockFieldDefine
{
	[Token(Token = "0x40061ED")]
	[FieldOffset(Offset = "0x1C")]
	public EditorValueType EditorValueType;

	[Token(Token = "0x40061EE")]
	[FieldOffset(Offset = "0x20")]
	public TypeInfo DefinedType;

	[Token(Token = "0x40061EF")]
	[FieldOffset(Offset = "0x28")]
	public int valueIndex;

	[Token(Token = "0x40061F0")]
	[FieldOffset(Offset = "0x2C")]
	public bool onlyForCodeBlock;

	[Token(Token = "0x40061F1")]
	[FieldOffset(Offset = "0x30")]
	public int BodyIndex;

	[Token(Token = "0x40061F2")]
	[FieldOffset(Offset = "0x34")]
	public int SerializeBlockFieldIndex;

	[Token(Token = "0x17000711")]
	public IOGCEGJJHLK valueType
	{
		[Token(Token = "0x6005807")]
		[Address(RVA = "0x2F50C1C", Offset = "0x2F50C1C", VA = "0x2F50C1C")]
		get
		{
			return default(IOGCEGJJHLK);
		}
	}

	[Token(Token = "0x6005806")]
	[Address(RVA = "0x2F4EA2C", Offset = "0x2F4EA2C", VA = "0x2F4EA2C")]
	public SerializeBlockFieldDefine()
	{
	}

	[Token(Token = "0x6005808")]
	[Address(RVA = "0x2F4EBB8", Offset = "0x2F4EBB8", VA = "0x2F4EBB8", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005809")]
	[Address(RVA = "0x2F50C7C", Offset = "0x2F50C7C", VA = "0x2F50C7C")]
	public bool RegisterToOwner(BlockDefine owner)
	{
		return default(bool);
	}

	[Token(Token = "0x600580A")]
	[Address(RVA = "0x2F50F30", Offset = "0x2F50F30", VA = "0x2F50F30")]
	public bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, BlockDefine P1, JsonData P2)
	{
		return default(bool);
	}
}
