using System;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B8F")]
public class VarDefineData
{
	[Token(Token = "0x40061CA")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x40061CB")]
	[FieldOffset(Offset = "0xC")]
	protected string varName;

	[Token(Token = "0x40061CC")]
	[FieldOffset(Offset = "0x10")]
	protected TypeInfo m_VarTypeInfo;

	[Token(Token = "0x40061CD")]
	[FieldOffset(Offset = "0x18")]
	internal bool isVarNameModified;

	[Token(Token = "0x40061CE")]
	[FieldOffset(Offset = "0x1C")]
	public ValueData defaultValue;

	[Token(Token = "0x40061CF")]
	[FieldOffset(Offset = "0x20")]
	public BlockData GetterData;

	[Token(Token = "0x40061D0")]
	[FieldOffset(Offset = "0x24")]
	public BlockData SetterData;

	[Token(Token = "0x40061D1")]
	[FieldOffset(Offset = "0x28")]
	public Action OnChanged;

	[Token(Token = "0x40061D2")]
	[FieldOffset(Offset = "0x2C")]
	public Action OnRemoved;

	[Token(Token = "0x40061D3")]
	[FieldOffset(Offset = "0x30")]
	public BlockEditContext Context;

	[Token(Token = "0x40061D4")]
	[FieldOffset(Offset = "0x34")]
	public GraphData Graph;

	[Token(Token = "0x40061D5")]
	[FieldOffset(Offset = "0x38")]
	public object UserRef;

	[Token(Token = "0x1700070E")]
	public virtual string VarName
	{
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0x2F55030", Offset = "0x2F55030", VA = "0x2F55030", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x2F55088", Offset = "0x2F55088", VA = "0x2F55088", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700070F")]
	public TypeInfo VarTypeInfo
	{
		[Token(Token = "0x60057E1")]
		[Address(RVA = "0x2F55198", Offset = "0x2F55198", VA = "0x2F55198")]
		get
		{
			return default(TypeInfo);
		}
		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x2F55204", Offset = "0x2F55204", VA = "0x2F55204")]
		set
		{
		}
	}

	[Token(Token = "0x17000710")]
	public virtual IOGCEGJJHLK VarType
	{
		[Token(Token = "0x60057E3")]
		[Address(RVA = "0x2F55418", Offset = "0x2F55418", VA = "0x2F55418", Slot = "6")]
		get
		{
			return default(IOGCEGJJHLK);
		}
		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x2F5549C", Offset = "0x2F5549C", VA = "0x2F5549C", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x60057DE")]
	[Address(RVA = "0x2F48D70", Offset = "0x2F48D70", VA = "0x2F48D70")]
	public VarDefineData()
	{
	}

	[Token(Token = "0x60057E5")]
	[Address(RVA = "0x2F4902C", Offset = "0x2F4902C", VA = "0x2F4902C", Slot = "8")]
	public virtual bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E6")]
	[Address(RVA = "0x2F4A01C", Offset = "0x2F4A01C", VA = "0x2F4A01C", Slot = "9")]
	public virtual bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E7")]
	[Address(RVA = "0x2F499DC", Offset = "0x2F499DC", VA = "0x2F499DC")]
	public bool UpdateGetter(BlockData getterData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E8")]
	[Address(RVA = "0x2F49C34", Offset = "0x2F49C34", VA = "0x2F49C34")]
	public bool UpdateSetter(BlockData setterData)
	{
		return default(bool);
	}
}
