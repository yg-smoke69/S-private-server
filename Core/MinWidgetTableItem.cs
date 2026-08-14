using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D23")]
public class MinWidgetTableItem : BaseTableItem
{
	[Token(Token = "0x40113A4")]
	[FieldOffset(Offset = "0x14")]
	private GameObject[] m_WidgetGOs;

	[Token(Token = "0x40113A5")]
	[FieldOffset(Offset = "0x18")]
	private ELayoutType m_SizType;

	[Token(Token = "0x40113A6")]
	[FieldOffset(Offset = "0x1C")]
	private List<ILayoutTableItem> m_Widgets;

	[Token(Token = "0x40113A7")]
	[FieldOffset(Offset = "0x20")]
	private ILayoutTableItem m_MinHorizontal;

	[Token(Token = "0x40113A8")]
	[FieldOffset(Offset = "0x24")]
	private ILayoutTableItem m_MinVertical;

	[Token(Token = "0x6012DF1")]
	[Address(RVA = "0x1C6E428", Offset = "0x1C6E428", VA = "0x1C6E428")]
	public MinWidgetTableItem()
	{
	}

	[Token(Token = "0x6012DF2")]
	[Address(RVA = "0x1C6E4B4", Offset = "0x1C6E4B4", VA = "0x1C6E4B4", Slot = "8")]
	public override void Init()
	{
	}

	[Token(Token = "0x6012DF3")]
	[Address(RVA = "0x1C6E794", Offset = "0x1C6E794", VA = "0x1C6E794", Slot = "9")]
	public override void UnInit()
	{
	}

	[Token(Token = "0x6012DF4")]
	[Address(RVA = "0x1C6E9B0", Offset = "0x1C6E9B0", VA = "0x1C6E9B0", Slot = "10")]
	public override Vector2 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012DF5")]
	[Address(RVA = "0x1C6EEFC", Offset = "0x1C6EEFC", VA = "0x1C6EEFC", Slot = "11")]
	protected override void EditorExecute()
	{
	}

	[Token(Token = "0x6012DF6")]
	[Address(RVA = "0x1C6F1E0", Offset = "0x1C6F1E0", VA = "0x1C6F1E0")]
	public ILayoutTableItem GetSelectedItem()
	{
		return null;
	}
}
