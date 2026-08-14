using System;
using System.Collections.Generic;
using COW;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004190")]
public class TestClothGame : COWGameBase
{
	[Token(Token = "0x2004191")]
	public enum Gender
	{
		[Token(Token = "0x401B7BC")]
		Female,
		[Token(Token = "0x401B7BD")]
		Male
	}

	[Token(Token = "0x401B7B5")]
	[FieldOffset(Offset = "0x0")]
	public static ResourceID TestClothScene;

	[Token(Token = "0x401B7B6")]
	[FieldOffset(Offset = "0x39")]
	private bool backupOffline;

	[Token(Token = "0x401B7B7")]
	[FieldOffset(Offset = "0x3C")]
	private uint currentAvatarId;

	[Token(Token = "0x401B7B8")]
	[FieldOffset(Offset = "0x40")]
	private Player currentPlayer;

	[Token(Token = "0x401B7B9")]
	[FieldOffset(Offset = "0x44")]
	private GameObject container;

	[Token(Token = "0x401B7BA")]
	[FieldOffset(Offset = "0x48")]
	protected GameObject m_UmaDcs;

	[Token(Token = "0x601AC76")]
	[Address(RVA = "0x21E0A5C", Offset = "0x21E0A5C", VA = "0x21E0A5C")]
	public TestClothGame()
	{
	}

	[Token(Token = "0x601AC77")]
	[Address(RVA = "0x21E0A64", Offset = "0x21E0A64", VA = "0x21E0A64", Slot = "18")]
	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	[Token(Token = "0x601AC78")]
	[Address(RVA = "0x21E0B40", Offset = "0x21E0B40", VA = "0x21E0B40", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x601AC79")]
	[Address(RVA = "0x21E0B48", Offset = "0x21E0B48", VA = "0x21E0B48", Slot = "27")]
	public override int GetSubGameType()
	{
		return default(int);
	}

	[Token(Token = "0x601AC7A")]
	[Address(RVA = "0x21E0B50", Offset = "0x21E0B50", VA = "0x21E0B50", Slot = "8")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x601AC7B")]
	[Address(RVA = "0x21E0BFC", Offset = "0x21E0BFC", VA = "0x21E0BFC")]
	protected void AddUmaDC()
	{
	}

	[Token(Token = "0x601AC7C")]
	[Address(RVA = "0x21E0E50", Offset = "0x21E0E50", VA = "0x21E0E50")]
	public void ReleaseUmaDc()
	{
	}

	[Token(Token = "0x601AC7D")]
	[Address(RVA = "0x21E0F28", Offset = "0x21E0F28", VA = "0x21E0F28", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x601AC7E")]
	[Address(RVA = "0x21E109C", Offset = "0x21E109C", VA = "0x21E109C")]
	private void CreateAvatar(uint avatarId)
	{
	}

	[Token(Token = "0x601AC7F")]
	[Address(RVA = "0x21E14C0", Offset = "0x21E14C0", VA = "0x21E14C0")]
	public void UpdateAvatarByClothId(List<uint> cids)
	{
	}

	[Token(Token = "0x601AC80")]
	[Address(RVA = "0x21E15F0", Offset = "0x21E15F0", VA = "0x21E15F0", Slot = "12")]
	protected override void OnDestroy()
	{
	}
}
