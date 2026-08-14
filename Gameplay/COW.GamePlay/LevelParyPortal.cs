using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000676")]
public class LevelParyPortal : BaseLevelObject
{
	[Token(Token = "0x2000677")]
	private sealed class PLAMCHOGADO
	{
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0x8")]
		internal Action OBKBCKDIAEF;

		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0xC")]
		internal LevelParyPortal GADHAMJEKIM;

		[Token(Token = "0x600295F")]
		[Address(RVA = "0x20BB29C", Offset = "0x20BB29C", VA = "0x20BB29C")]
		public PLAMCHOGADO()
		{
		}

		[Token(Token = "0x6002960")]
		[Address(RVA = "0x20BB3C4", Offset = "0x20BB3C4", VA = "0x20BB3C4")]
		internal void CHOPCLCOBKC()
		{
		}

		[Token(Token = "0x6002961")]
		[Address(RVA = "0x20BB68C", Offset = "0x20BB68C", VA = "0x20BB68C")]
		internal void HJGBDJENEAM()
		{
		}
	}

	[Token(Token = "0x40047F4")]
	[FieldOffset(Offset = "0x74")]
	public uint portalid;

	[Token(Token = "0x40047F5")]
	[FieldOffset(Offset = "0x78")]
	public float Radius;

	[Token(Token = "0x40047F6")]
	[FieldOffset(Offset = "0x7C")]
	public Transform[] SpawnPoints;

	[Token(Token = "0x40047F7")]
	[FieldOffset(Offset = "0x80")]
	private uint MMNFABGNKAJ;

	[Token(Token = "0x6002957")]
	[Address(RVA = "0x20BADAC", Offset = "0x20BADAC", VA = "0x20BADAC")]
	public LevelParyPortal()
	{
	}

	[Token(Token = "0x6002958")]
	[Address(RVA = "0x20BADB4", Offset = "0x20BADB4", VA = "0x20BADB4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002959")]
	[Address(RVA = "0x20BAE58", Offset = "0x20BAE58", VA = "0x20BAE58", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600295A")]
	[Address(RVA = "0x20BAEBC", Offset = "0x20BAEBC", VA = "0x20BAEBC", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x600295B")]
	[Address(RVA = "0x20BAF20", Offset = "0x20BAF20", VA = "0x20BAF20")]
	public void OnLocalPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x600295C")]
	[Address(RVA = "0x20BB2A4", Offset = "0x20BB2A4", VA = "0x20BB2A4")]
	public void OnLocalPlayerExitTrigger()
	{
	}

	[Token(Token = "0x600295D")]
	[Address(RVA = "0x20BB3B4", Offset = "0x20BB3B4", VA = "0x20BB3B4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600295E")]
	[Address(RVA = "0x20BB3BC", Offset = "0x20BB3BC", VA = "0x20BB3BC")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
