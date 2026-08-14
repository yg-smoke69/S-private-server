using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029B3")]
internal class UIMatchResultZombieScreenshotController : UIBaseController
{
	[Token(Token = "0x20029B4")]
	public class MatchResultScreenshotData
	{
		[Token(Token = "0x20029B5")]
		public class TeammateData
		{
			[Token(Token = "0x40100BF")]
			[FieldOffset(Offset = "0x8")]
			public string Nickname;

			[Token(Token = "0x40100C0")]
			[FieldOffset(Offset = "0xC")]
			public uint Kills;

			[Token(Token = "0x40100C1")]
			[FieldOffset(Offset = "0x10")]
			public uint Damages;

			[Token(Token = "0x40100C2")]
			[FieldOffset(Offset = "0x14")]
			public uint Weapon_id;

			[Token(Token = "0x40100C3")]
			[FieldOffset(Offset = "0x18")]
			public ulong account_id;

			[Token(Token = "0x6010C30")]
			[Address(RVA = "0x268F604", Offset = "0x268F604", VA = "0x268F604")]
			public TeammateData()
			{
			}
		}

		[Token(Token = "0x40100B0")]
		[FieldOffset(Offset = "0x8")]
		public uint All_Damages;

		[Token(Token = "0x40100B1")]
		[FieldOffset(Offset = "0xC")]
		public string Defeater;

		[Token(Token = "0x40100B2")]
		[FieldOffset(Offset = "0x10")]
		public string WeaponDefeatedWith;

		[Token(Token = "0x40100B3")]
		[FieldOffset(Offset = "0x14")]
		public bool DefeaterIsZombie;

		[Token(Token = "0x40100B4")]
		[FieldOffset(Offset = "0x18")]
		public ulong mvp_id;

		[Token(Token = "0x40100B5")]
		[FieldOffset(Offset = "0x20")]
		public uint Kills;

		[Token(Token = "0x40100B6")]
		[FieldOffset(Offset = "0x24")]
		public uint Damages;

		[Token(Token = "0x40100B7")]
		[FieldOffset(Offset = "0x28")]
		public uint SurvivedTime_s;

		[Token(Token = "0x40100B8")]
		[FieldOffset(Offset = "0x2C")]
		public uint Rank;

		[Token(Token = "0x40100B9")]
		[FieldOffset(Offset = "0x30")]
		public uint TotalPlayersCount;

		[Token(Token = "0x40100BA")]
		[FieldOffset(Offset = "0x34")]
		public TeammateData[] Teammates;

		[Token(Token = "0x40100BB")]
		[FieldOffset(Offset = "0x38")]
		public uint MatchMode;

		[Token(Token = "0x40100BC")]
		[FieldOffset(Offset = "0x3C")]
		public uint GameMode;

		[Token(Token = "0x40100BD")]
		[FieldOffset(Offset = "0x40")]
		public uint MapID;

		[Token(Token = "0x40100BE")]
		[FieldOffset(Offset = "0x44")]
		public MatchStats MatchStats;

		[Token(Token = "0x6010C2F")]
		[Address(RVA = "0x268FA58", Offset = "0x268FA58", VA = "0x268FA58")]
		public MatchResultScreenshotData()
		{
		}
	}

	[Token(Token = "0x40100AA")]
	[FieldOffset(Offset = "0x28")]
	private UIMatchResultZombieScreenshotView m_View;

	[Token(Token = "0x40100AB")]
	[FieldOffset(Offset = "0x2C")]
	private MatchResultScreenshotData m_Data;

	[Token(Token = "0x40100AC")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_BackgroundRenderTexture;

	[Token(Token = "0x40100AD")]
	[FieldOffset(Offset = "0x34")]
	private RenderTexture m_ScreenShotRenderTexture;

	[Token(Token = "0x40100AE")]
	[FieldOffset(Offset = "0x38")]
	private int m_ScreenShotStepCount;

	[Token(Token = "0x40100AF")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<TeammateStats, MatchResultScreenshotData.TeammateData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010C1A")]
	[Address(RVA = "0x268BD94", Offset = "0x268BD94", VA = "0x268BD94")]
	public UIMatchResultZombieScreenshotController()
	{
	}

	[Token(Token = "0x6010C1B")]
	[Address(RVA = "0x268BE18", Offset = "0x268BE18", VA = "0x268BE18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C1C")]
	[Address(RVA = "0x268BEC0", Offset = "0x268BEC0", VA = "0x268BEC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C1D")]
	[Address(RVA = "0x268C00C", Offset = "0x268C00C", VA = "0x268C00C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010C1E")]
	[Address(RVA = "0x268C070", Offset = "0x268C070", VA = "0x268C070")]
	public void MakeScreenshot(MatchResultScreenshotData data)
	{
	}

	[Token(Token = "0x6010C1F")]
	[Address(RVA = "0x268C320", Offset = "0x268C320", VA = "0x268C320")]
	private void UpdatePlayerData()
	{
	}

	[Token(Token = "0x6010C20")]
	[Address(RVA = "0x268D890", Offset = "0x268D890", VA = "0x268D890")]
	private void UpdateHeadshot()
	{
	}

	[Token(Token = "0x6010C21")]
	[Address(RVA = "0x268DC18", Offset = "0x268DC18", VA = "0x268DC18")]
	private void UpdateHeadshot(uint iid)
	{
	}

	[Token(Token = "0x6010C22")]
	[Address(RVA = "0x268DD88", Offset = "0x268DD88", VA = "0x268DD88")]
	private void UpdateHeadshot(HeadPicData data)
	{
	}

	[Token(Token = "0x6010C23")]
	[Address(RVA = "0x268CD28", Offset = "0x268CD28", VA = "0x268CD28")]
	private void UpdateHighlightRank()
	{
	}

	[Token(Token = "0x6010C24")]
	[Address(RVA = "0x268CFEC", Offset = "0x268CFEC", VA = "0x268CFEC")]
	private void UpdateDetailData()
	{
	}

	[Token(Token = "0x6010C25")]
	[Address(RVA = "0x268C8F0", Offset = "0x268C8F0", VA = "0x268C8F0")]
	private void UpdatePlayerCharacterImage()
	{
	}

	[Token(Token = "0x6010C26")]
	[Address(RVA = "0x268D2F4", Offset = "0x268D2F4", VA = "0x268D2F4")]
	private void UpdateGameInfo()
	{
	}

	[Token(Token = "0x6010C27")]
	[Address(RVA = "0x268D5BC", Offset = "0x268D5BC", VA = "0x268D5BC")]
	private void StartRenderBackground()
	{
	}

	[Token(Token = "0x6010C28")]
	[Address(RVA = "0x268ECA0", Offset = "0x268ECA0", VA = "0x268ECA0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6010C29")]
	[Address(RVA = "0x268EE08", Offset = "0x268EE08", VA = "0x268EE08")]
	private void FinishRenderBackground()
	{
	}

	[Token(Token = "0x6010C2A")]
	[Address(RVA = "0x268F2E0", Offset = "0x268F2E0", VA = "0x268F2E0")]
	private void TakeScreenshot()
	{
	}

	[Token(Token = "0x6010C2B")]
	[Address(RVA = "0x268F4F0", Offset = "0x268F4F0", VA = "0x268F4F0")]
	private static MatchResultScreenshotData.TeammateData _003CMakeScreenshot_003Em__0(TeammateStats datum)
	{
		return null;
	}

	[Token(Token = "0x6010C2C")]
	[Address(RVA = "0x268F60C", Offset = "0x268F60C", VA = "0x268F60C")]
	private void _003CTakeScreenshot_003Em__1()
	{
	}

	[Token(Token = "0x6010C2D")]
	[Address(RVA = "0x268FA48", Offset = "0x268FA48", VA = "0x268FA48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C2E")]
	[Address(RVA = "0x268FA50", Offset = "0x268FA50", VA = "0x268FA50")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
