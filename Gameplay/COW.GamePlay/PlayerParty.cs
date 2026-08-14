using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20009A9")]
internal class PlayerParty : PlayerNetwork
{
	[Token(Token = "0x4005996")]
	[FieldOffset(Offset = "0x9C8")]
	private BNLEDHJHBNE CBBHAACNCCK;

	[Token(Token = "0x4005997")]
	[FieldOffset(Offset = "0x9CC")]
	private ResourceID GHNKMMHCBAF;

	[Token(Token = "0x4005998")]
	[FieldOffset(Offset = "0x9D0")]
	private WheelRollComboView FIHDGKLKPJC;

	[Token(Token = "0x4005999")]
	[FieldOffset(Offset = "0x9D4")]
	private Dictionary<uint, PartyBeatEffectData> DOJAMNHEICM;

	[Token(Token = "0x400599A")]
	[FieldOffset(Offset = "0x9D8")]
	private GameObject PIJPFJJKAKG;

	[Token(Token = "0x170005F0")]
	public int DKPNPFFOBMK
	{
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x20FE3A0", Offset = "0x20FE3A0", VA = "0x20FE3A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005F1")]
	public sbyte MJJLNNIACMG
	{
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x20FE4C8", Offset = "0x20FE4C8", VA = "0x20FE4C8")]
		get
		{
			return default(sbyte);
		}
	}

	[Token(Token = "0x6004AAF")]
	[Address(RVA = "0x20FDDF4", Offset = "0x20FDDF4", VA = "0x20FDDF4")]
	public PlayerParty()
	{
	}

	[Token(Token = "0x6004AB0")]
	[Address(RVA = "0x20FDE94", Offset = "0x20FDE94", VA = "0x20FDE94", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004AB3")]
	[Address(RVA = "0x20FE5EC", Offset = "0x20FE5EC", VA = "0x20FE5EC", Slot = "111")]
	public override void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004AB4")]
	[Address(RVA = "0x20FE7A0", Offset = "0x20FE7A0", VA = "0x20FE7A0", Slot = "112")]
	public override void OnTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004AB5")]
	[Address(RVA = "0x20FEEB4", Offset = "0x20FEEB4", VA = "0x20FEEB4")]
	private void BHLJBDKDGFI(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004AB6")]
	[Address(RVA = "0x20FF000", Offset = "0x20FF000", VA = "0x20FF000")]
	private void NLLJICAAMAE(float JGLJDJFHPBO, float DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004AB7")]
	[Address(RVA = "0x20FF388", Offset = "0x20FF388", VA = "0x20FF388")]
	private void KEBHLPMBFEA(sbyte JGLJDJFHPBO, sbyte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004AB8")]
	[Address(RVA = "0x20FF7D4", Offset = "0x20FF7D4", VA = "0x20FF7D4")]
	private void MBLGGFNEEAD(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004AB9")]
	[Address(RVA = "0x20FF9B4", Offset = "0x20FF9B4", VA = "0x20FF9B4")]
	private void KDLKMENGBDL(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004ABA")]
	[Address(RVA = "0x20FFBB4", Offset = "0x20FFBB4", VA = "0x20FFBB4")]
	public void SetComboView(int BJHEDKLAFCO)
	{
	}

	[Token(Token = "0x6004ABB")]
	[Address(RVA = "0x20FE97C", Offset = "0x20FE97C", VA = "0x20FE97C")]
	public void PlayPartyGameEffect(ResourceID ALDFONNHHEL)
	{
	}

	[Token(Token = "0x6004ABC")]
	[Address(RVA = "0x20FFF94", Offset = "0x20FFF94", VA = "0x20FFF94")]
	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004ABD")]
	[Address(RVA = "0x20FFF9C", Offset = "0x20FFF9C", VA = "0x20FFF9C")]
	public void _003C_003EiFixBaseProxy_OnTriggerEnter(Collider P0)
	{
	}

	[Token(Token = "0x6004ABE")]
	[Address(RVA = "0x20FFFA4", Offset = "0x20FFFA4", VA = "0x20FFFA4")]
	public void _003C_003EiFixBaseProxy_OnTriggerExit(Collider P0)
	{
	}
}
