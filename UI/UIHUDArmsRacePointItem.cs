using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001FA6")]
public class UIHUDArmsRacePointItem : MonoBehaviour
{
	[Token(Token = "0x400C67E")]
	[FieldOffset(Offset = "0xC")]
	public GameObject EmptyContainer;

	[Token(Token = "0x400C67F")]
	[FieldOffset(Offset = "0x10")]
	public GameObject LightingContainer;

	[Token(Token = "0x400C680")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsBanned;

	[Token(Token = "0x400C681")]
	[FieldOffset(Offset = "0x15")]
	private bool m_IsEmpty;

	[Token(Token = "0x6009DC6")]
	[Address(RVA = "0x147EB34", Offset = "0x147EB34", VA = "0x147EB34")]
	public UIHUDArmsRacePointItem()
	{
	}

	[Token(Token = "0x6009DC7")]
	[Address(RVA = "0x147EB3C", Offset = "0x147EB3C", VA = "0x147EB3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6009DC8")]
	[Address(RVA = "0x147EB40", Offset = "0x147EB40", VA = "0x147EB40")]
	public void Empty()
	{
	}

	[Token(Token = "0x6009DC9")]
	[Address(RVA = "0x147EBFC", Offset = "0x147EBFC", VA = "0x147EBFC")]
	public void Light()
	{
	}

	[Token(Token = "0x6009DCA")]
	[Address(RVA = "0x147EC6C", Offset = "0x147EC6C", VA = "0x147EC6C")]
	public void Ban()
	{
	}

	[Token(Token = "0x6009DCB")]
	[Address(RVA = "0x147EBB0", Offset = "0x147EBB0", VA = "0x147EBB0")]
	public void UnBan()
	{
	}

	[Token(Token = "0x6009DCC")]
	[Address(RVA = "0x147ECB8", Offset = "0x147ECB8", VA = "0x147ECB8")]
	public bool IsBan()
	{
		return default(bool);
	}
}
