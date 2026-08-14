using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E61")]
public class CFullScreenWindow_VTabsPanelData : _Attribute
{
	[Token(Token = "0x2002E62")]
	public class TabItem
	{
		[Token(Token = "0x4011B78")]
		[FieldOffset(Offset = "0x8")]
		public string labelKey;

		[Token(Token = "0x4011B79")]
		[FieldOffset(Offset = "0xC")]
		public IModeEditComponentData contentComponent;

		[Token(Token = "0x4011B7A")]
		[FieldOffset(Offset = "0x10")]
		public ModeVariableBinding enabled;

		[Token(Token = "0x6013653")]
		[Address(RVA = "0x181554C", Offset = "0x181554C", VA = "0x181554C")]
		public TabItem()
		{
		}
	}

	[Token(Token = "0x4011B75")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B76")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding itemIndex;

	[Token(Token = "0x4011B77")]
	[FieldOffset(Offset = "0x10")]
	public List<TabItem> items;

	[Token(Token = "0x17001419")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013650")]
		[Address(RVA = "0x181518C", Offset = "0x181518C", VA = "0x181518C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013651")]
		[Address(RVA = "0x1815194", Offset = "0x1815194", VA = "0x1815194", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x601364F")]
	[Address(RVA = "0x1815184", Offset = "0x1815184", VA = "0x1815184")]
	public CFullScreenWindow_VTabsPanelData()
	{
	}

	[Token(Token = "0x6013652")]
	[Address(RVA = "0x181519C", Offset = "0x181519C", VA = "0x181519C", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
