using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E63")]
public class CHTabsPanelData : _Attribute
{
	[Token(Token = "0x2002E64")]
	public class TabItem
	{
		[Token(Token = "0x4011B7F")]
		[FieldOffset(Offset = "0x8")]
		public string labelKey;

		[Token(Token = "0x4011B80")]
		[FieldOffset(Offset = "0xC")]
		public string subLabelKey;

		[Token(Token = "0x4011B81")]
		[FieldOffset(Offset = "0x10")]
		public IModeEditComponentData contentComponent;

		[Token(Token = "0x4011B82")]
		[FieldOffset(Offset = "0x14")]
		public bool IsHidden;

		[Token(Token = "0x6013658")]
		[Address(RVA = "0x1815B48", Offset = "0x1815B48", VA = "0x1815B48")]
		public TabItem()
		{
		}
	}

	[Token(Token = "0x4011B7B")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B7C")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding unselectable;

	[Token(Token = "0x4011B7D")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding itemIndex;

	[Token(Token = "0x4011B7E")]
	[FieldOffset(Offset = "0x14")]
	public List<TabItem> items;

	[Token(Token = "0x1700141A")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013655")]
		[Address(RVA = "0x181555C", Offset = "0x181555C", VA = "0x181555C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013656")]
		[Address(RVA = "0x1815564", Offset = "0x1815564", VA = "0x1815564", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013654")]
	[Address(RVA = "0x1815554", Offset = "0x1815554", VA = "0x1815554")]
	public CHTabsPanelData()
	{
	}

	[Token(Token = "0x6013657")]
	[Address(RVA = "0x181556C", Offset = "0x181556C", VA = "0x181556C", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
