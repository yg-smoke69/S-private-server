using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D20")]
public class GridTableItem : BaseTableItem
{
	[Token(Token = "0x401138E")]
	[FieldOffset(Offset = "0x14")]
	private UIGrid m_Grid;

	[Token(Token = "0x401138F")]
	[FieldOffset(Offset = "0x18")]
	private float m_PadLeft;

	[Token(Token = "0x4011390")]
	[FieldOffset(Offset = "0x1C")]
	private float m_PadRight;

	[Token(Token = "0x4011391")]
	[FieldOffset(Offset = "0x20")]
	private float m_PadBottom;

	[Token(Token = "0x4011392")]
	[FieldOffset(Offset = "0x24")]
	private float m_PadUp;

	[Token(Token = "0x4011393")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_PresetRealItemSize;

	[Token(Token = "0x4011394")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 m_RealItemSize;

	[Token(Token = "0x4011395")]
	[FieldOffset(Offset = "0x38")]
	private int m_ActiveCount;

	[Token(Token = "0x4011396")]
	[FieldOffset(Offset = "0x3C")]
	private int m_PresetCount;

	[Token(Token = "0x6012DDA")]
	[Address(RVA = "0x350BFA4", Offset = "0x350BFA4", VA = "0x350BFA4")]
	public GridTableItem()
	{
	}

	[Token(Token = "0x6012DDB")]
	[Address(RVA = "0x350BFAC", Offset = "0x350BFAC", VA = "0x350BFAC", Slot = "8")]
	public override void Init()
	{
	}

	[Token(Token = "0x6012DDC")]
	[Address(RVA = "0x350C510", Offset = "0x350C510", VA = "0x350C510", Slot = "9")]
	public override void UnInit()
	{
	}

	[Token(Token = "0x6012DDD")]
	[Address(RVA = "0x350C5F4", Offset = "0x350C5F4", VA = "0x350C5F4")]
	public void UsePresetCount(int count)
	{
	}

	[Token(Token = "0x6012DDE")]
	[Address(RVA = "0x350C5FC", Offset = "0x350C5FC", VA = "0x350C5FC", Slot = "10")]
	public override Vector2 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012DDF")]
	[Address(RVA = "0x350C8A4", Offset = "0x350C8A4", VA = "0x350C8A4", Slot = "11")]
	protected override void EditorExecute()
	{
	}
}
