using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D1F")]
public class GridOrWidgetTableItem : BaseTableItem
{
	[Token(Token = "0x401138A")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_WidgetGO;

	[Token(Token = "0x401138B")]
	[FieldOffset(Offset = "0x18")]
	private GridTableItem m_Grid;

	[Token(Token = "0x401138C")]
	[FieldOffset(Offset = "0x1C")]
	private ELayoutType m_SizType;

	[Token(Token = "0x401138D")]
	[FieldOffset(Offset = "0x20")]
	private ILayoutTableItem m_Widget;

	[Token(Token = "0x6012DD6")]
	[Address(RVA = "0x350BB30", Offset = "0x350BB30", VA = "0x350BB30")]
	public GridOrWidgetTableItem()
	{
	}

	[Token(Token = "0x6012DD7")]
	[Address(RVA = "0x350BB38", Offset = "0x350BB38", VA = "0x350BB38", Slot = "8")]
	public override void Init()
	{
	}

	[Token(Token = "0x6012DD8")]
	[Address(RVA = "0x350BC7C", Offset = "0x350BC7C", VA = "0x350BC7C", Slot = "9")]
	public override void UnInit()
	{
	}

	[Token(Token = "0x6012DD9")]
	[Address(RVA = "0x350BD84", Offset = "0x350BD84", VA = "0x350BD84", Slot = "10")]
	public override Vector2 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
