using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2004195")]
internal class WalkAroundGame : MatchGame
{
	[Token(Token = "0x2004196")]
	public enum Gender
	{
		[Token(Token = "0x401B7D8")]
		Female,
		[Token(Token = "0x401B7D9")]
		Male
	}

	[Token(Token = "0x401B7D0")]
	[FieldOffset(Offset = "0x0")]
	public static ResourceID WalkAroundScene;

	[Token(Token = "0x401B7D1")]
	[FieldOffset(Offset = "0x84")]
	protected BMHHFBDLHMP m_MatchContextData;

	[Token(Token = "0x401B7D2")]
	[FieldOffset(Offset = "0x88")]
	private bool backupOffline;

	[Token(Token = "0x401B7D3")]
	[FieldOffset(Offset = "0x8C")]
	private uint currentAvatarId;

	[Token(Token = "0x401B7D4")]
	[FieldOffset(Offset = "0x90")]
	private Player currentPlayer;

	[Token(Token = "0x401B7D5")]
	[FieldOffset(Offset = "0x94")]
	private GameObject container;

	[Token(Token = "0x401B7D6")]
	[FieldOffset(Offset = "0x98")]
	protected new GameObject m_UmaDcs;

	[Token(Token = "0x601AC9E")]
	[Address(RVA = "0x21A1D9C", Offset = "0x21A1D9C", VA = "0x21A1D9C")]
	public WalkAroundGame()
	{
	}

	[Token(Token = "0x601AC9F")]
	[Address(RVA = "0x21A1E3C", Offset = "0x21A1E3C", VA = "0x21A1E3C", Slot = "18")]
	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	[Token(Token = "0x601ACA0")]
	[Address(RVA = "0x21A1F38", Offset = "0x21A1F38", VA = "0x21A1F38", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x601ACA1")]
	[Address(RVA = "0x21A2014", Offset = "0x21A2014", VA = "0x21A2014", Slot = "27")]
	public override int GetSubGameType()
	{
		return default(int);
	}

	[Token(Token = "0x601ACA2")]
	[Address(RVA = "0x21A206C", Offset = "0x21A206C", VA = "0x21A206C", Slot = "8")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x601ACA3")]
	[Address(RVA = "0x21A2160", Offset = "0x21A2160", VA = "0x21A2160")]
	protected new void AddUmaDC()
	{
	}

	[Token(Token = "0x601ACA4")]
	[Address(RVA = "0x21A2400", Offset = "0x21A2400", VA = "0x21A2400")]
	public new void ReleaseUmaDc()
	{
	}

	[Token(Token = "0x601ACA5")]
	[Address(RVA = "0x21A2520", Offset = "0x21A2520", VA = "0x21A2520", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x601ACA6")]
	[Address(RVA = "0x21A2C04", Offset = "0x21A2C04", VA = "0x21A2C04", Slot = "58")]
	protected virtual void OnGameSetup()
	{
	}

	[Token(Token = "0x601ACA7")]
	[Address(RVA = "0x21A3270", Offset = "0x21A3270", VA = "0x21A3270")]
	private void CreateAvatar(uint avatarId)
	{
	}

	[Token(Token = "0x601ACA8")]
	[Address(RVA = "0x21A3638", Offset = "0x21A3638", VA = "0x21A3638")]
	public void UpdateAvatarByClothId(List<uint> cids)
	{
	}

	[Token(Token = "0x601ACA9")]
	[Address(RVA = "0x21A37B4", Offset = "0x21A37B4", VA = "0x21A37B4", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601ACAA")]
	[Address(RVA = "0x21A389C", Offset = "0x21A389C", VA = "0x21A389C", Slot = "15")]
	protected override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x601ACAB")]
	[Address(RVA = "0x21A396C", Offset = "0x21A396C", VA = "0x21A396C", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x601ACAC")]
	[Address(RVA = "0x21A3A3C", Offset = "0x21A3A3C", VA = "0x21A3A3C", Slot = "20")]
	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x601ACAD")]
	[Address(RVA = "0x21A3A94", Offset = "0x21A3A94", VA = "0x21A3A94", Slot = "21")]
	public override ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x601ACAE")]
	[Address(RVA = "0x21A3AEC", Offset = "0x21A3AEC", VA = "0x21A3AEC")]
	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x601ACAF")]
	[Address(RVA = "0x21A3AF4", Offset = "0x21A3AF4", VA = "0x21A3AF4")]
	public int _003C_003EiFixBaseProxy_GetSubGameType()
	{
		return default(int);
	}

	[Token(Token = "0x601ACB0")]
	[Address(RVA = "0x21A3AFC", Offset = "0x21A3AFC", VA = "0x21A3AFC")]
	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x601ACB1")]
	[Address(RVA = "0x21A3B04", Offset = "0x21A3B04", VA = "0x21A3B04")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	[Token(Token = "0x601ACB2")]
	[Address(RVA = "0x21A3B0C", Offset = "0x21A3B0C", VA = "0x21A3B0C")]
	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x601ACB3")]
	[Address(RVA = "0x21A3B14", Offset = "0x21A3B14", VA = "0x21A3B14")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	[Token(Token = "0x601ACB4")]
	[Address(RVA = "0x21A3B1C", Offset = "0x21A3B1C", VA = "0x21A3B1C")]
	public void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	[Token(Token = "0x601ACB5")]
	[Address(RVA = "0x21A3B24", Offset = "0x21A3B24", VA = "0x21A3B24")]
	public new ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x601ACB6")]
	[Address(RVA = "0x21A3B2C", Offset = "0x21A3B2C", VA = "0x21A3B2C")]
	public ResourceID[] _003C_003EiFixBaseProxy_GetAudioPreloadResourceID()
	{
		return null;
	}
}
