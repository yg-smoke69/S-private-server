using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2004129")]
public class UICenterTargetHelper : MonoBehaviour
{
	[Token(Token = "0x401B5DA")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget[] m_WidgetArray;

	[Token(Token = "0x401B5DB")]
	[FieldOffset(Offset = "0x10")]
	public float[] m_GapBetweenWidgetArray;

	[Token(Token = "0x401B5DC")]
	[FieldOffset(Offset = "0x14")]
	private float[] m_WidgetSizeXArray;

	[Token(Token = "0x401B5DD")]
	[FieldOffset(Offset = "0x18")]
	private float m_TotalSize;

	[Token(Token = "0x401B5DE")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_IsIgnoreInactive;

	[Token(Token = "0x601AA17")]
	[Address(RVA = "0x1458E9C", Offset = "0x1458E9C", VA = "0x1458E9C")]
	public UICenterTargetHelper()
	{
	}

	[Token(Token = "0x601AA18")]
	[Address(RVA = "0x1458EA4", Offset = "0x1458EA4", VA = "0x1458EA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AA19")]
	[Address(RVA = "0x14590B4", Offset = "0x14590B4", VA = "0x14590B4")]
	public void InitHelper()
	{
	}

	[Token(Token = "0x601AA1A")]
	[Address(RVA = "0x1459E9C", Offset = "0x1459E9C", VA = "0x1459E9C")]
	public void ClearGapArray()
	{
	}

	[Token(Token = "0x601AA1B")]
	[Address(RVA = "0x1459788", Offset = "0x1459788", VA = "0x1459788")]
	private float GetWidgetPosOffset(UIWidget widget)
	{
		return default(float);
	}

	[Token(Token = "0x601AA1C")]
	[Address(RVA = "0x14598B0", Offset = "0x14598B0", VA = "0x14598B0")]
	private void LayoutLabel()
	{
	}
}
