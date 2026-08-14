using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CE4")]
public class EdgeDetectHudItem : CustomHudItem
{
	[Token(Token = "0x4011211")]
	[FieldOffset(Offset = "0x28")]
	protected UIWidget m_Wiget;

	[Token(Token = "0x4011212")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_ScreenWidth;

	[Token(Token = "0x4011213")]
	[FieldOffset(Offset = "0x30")]
	protected int m_ScreenHeight;

	[Token(Token = "0x6012C97")]
	[Address(RVA = "0x252121C", Offset = "0x252121C", VA = "0x252121C")]
	public EdgeDetectHudItem()
	{
	}

	[Token(Token = "0x6012C98")]
	[Address(RVA = "0x2521224", Offset = "0x2521224", VA = "0x2521224", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6012C99")]
	[Address(RVA = "0x25213FC", Offset = "0x25213FC", VA = "0x25213FC", Slot = "7")]
	protected override void OnHudDragEnd(GameObject go)
	{
	}

	[Token(Token = "0x6012C9A")]
	[Address(RVA = "0x25215D0", Offset = "0x25215D0", VA = "0x25215D0", Slot = "8")]
	public virtual void EdgeDetect()
	{
	}

	[Token(Token = "0x6012C9B")]
	[Address(RVA = "0x25218C4", Offset = "0x25218C4", VA = "0x25218C4")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x6012C9C")]
	[Address(RVA = "0x25218CC", Offset = "0x25218CC", VA = "0x25218CC")]
	public void _003C_003EiFixBaseProxy_OnHudDragEnd(GameObject P0)
	{
	}
}
