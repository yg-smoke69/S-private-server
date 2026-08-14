using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E6D")]
public class CPopMenuData : _Attribute
{
	[Token(Token = "0x2002E6E")]
	public class PopMenuItem
	{
		[Token(Token = "0x4011BAD")]
		[FieldOffset(Offset = "0x8")]
		public string labelKey;

		[Token(Token = "0x4011BAE")]
		[FieldOffset(Offset = "0xC")]
		public ModeVariableBinding value;

		[Token(Token = "0x4011BAF")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x601367C")]
		[Address(RVA = "0x18207AC", Offset = "0x18207AC", VA = "0x18207AC")]
		public PopMenuItem()
		{
		}
	}

	[Token(Token = "0x2002E6F")]
	public class IntItems
	{
		[Token(Token = "0x4011BB0")]
		[FieldOffset(Offset = "0x8")]
		public ModeVariableBinding start;

		[Token(Token = "0x4011BB1")]
		[FieldOffset(Offset = "0xC")]
		public ModeVariableBinding end;

		[Token(Token = "0x601367D")]
		[Address(RVA = "0x182054C", Offset = "0x182054C", VA = "0x182054C")]
		public IntItems()
		{
		}
	}

	[Token(Token = "0x4011BA3")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011BA4")]
	[FieldOffset(Offset = "0xC")]
	public IntItems IntItemsDesc;

	[Token(Token = "0x4011BA5")]
	[FieldOffset(Offset = "0x10")]
	public List<PopMenuItem> items;

	[Token(Token = "0x4011BA6")]
	[FieldOffset(Offset = "0x14")]
	public ModeVariableBinding value;

	[Token(Token = "0x4011BA7")]
	[FieldOffset(Offset = "0x18")]
	public ModeVariableBinding width;

	[Token(Token = "0x4011BA8")]
	[FieldOffset(Offset = "0x1C")]
	public ModeVariableBinding dirUp;

	[Token(Token = "0x4011BA9")]
	[FieldOffset(Offset = "0x20")]
	public ModeVariableBinding addDepth;

	[Token(Token = "0x4011BAA")]
	[FieldOffset(Offset = "0x24")]
	public ModeVariableBinding selectable;

	[Token(Token = "0x4011BAB")]
	[FieldOffset(Offset = "0x28")]
	public ModeVariableBinding HasPicker;

	[Token(Token = "0x4011BAC")]
	[FieldOffset(Offset = "0x2C")]
	public bool internalSelectable;

	[Token(Token = "0x17001422")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013677")]
		[Address(RVA = "0x181FD70", Offset = "0x181FD70", VA = "0x181FD70", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013678")]
		[Address(RVA = "0x181FD78", Offset = "0x181FD78", VA = "0x181FD78", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013676")]
	[Address(RVA = "0x181FD60", Offset = "0x181FD60", VA = "0x181FD60")]
	public CPopMenuData()
	{
	}

	[Token(Token = "0x6013679")]
	[Address(RVA = "0x181FD80", Offset = "0x181FD80", VA = "0x181FD80", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x601367A")]
	[Address(RVA = "0x18207B4", Offset = "0x18207B4", VA = "0x18207B4")]
	public void ResetIntItemsAction()
	{
	}

	[Token(Token = "0x601367B")]
	[Address(RVA = "0x1820554", Offset = "0x1820554", VA = "0x1820554")]
	public bool ResetIntItems()
	{
		return default(bool);
	}
}
