using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005BD")]
public class EmoteLeaderCollider : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40043B2")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG DOEMBMDMEJA;

	[Token(Token = "0x40043B3")]
	[FieldOffset(Offset = "0x28")]
	private SphereCollider DLCFLIABAHA;

	[Token(Token = "0x40043B4")]
	[FieldOffset(Offset = "0x2C")]
	protected EntityInfo KLFNNKMBBHD;

	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x191DA3C", Offset = "0x191DA3C", VA = "0x191DA3C")]
	public EmoteLeaderCollider()
	{
	}

	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x191DA44", Offset = "0x191DA44", VA = "0x191DA44")]
	public void Init(IHAAMHPPLMG FIMNKGABILM)
	{
	}

	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x191DDF8", Offset = "0x191DDF8", VA = "0x191DDF8")]
	public void Release()
	{
	}

	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x191DF34", Offset = "0x191DF34", VA = "0x191DF34")]
	public IHAAMHPPLMG GetOwnerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x60022D7")]
	[Address(RVA = "0x191DCE0", Offset = "0x191DCE0", VA = "0x191DCE0", Slot = "4")]
	public void InitEntityInfo()
	{
	}

	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x191DFA8", Offset = "0x191DFA8", VA = "0x191DFA8", Slot = "5")]
	public EntityInfo GetEntityInfo()
	{
		return default(EntityInfo);
	}

	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x191E014", Offset = "0x191E014", VA = "0x191E014")]
	public static bool CanTrigger(EntityInfo GFLMAPGLDFP)
	{
		return default(bool);
	}
}
