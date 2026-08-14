using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029AD")]
internal class UIMatchResultScreenshotController : UIBaseController
{
	[Token(Token = "0x20029AE")]
	public class MatchResultScreenshotData
	{
		[Token(Token = "0x20029AF")]
		public class TeammateData
		{
			[Token(Token = "0x4010097")]
			[FieldOffset(Offset = "0x8")]
			public string Nickname;

			[Token(Token = "0x4010098")]
			[FieldOffset(Offset = "0xC")]
			public uint Kills;

			[Token(Token = "0x6010C0A")]
			[Address(RVA = "0x2688A80", Offset = "0x2688A80", VA = "0x2688A80")]
			public TeammateData()
			{
			}
		}

		[Token(Token = "0x4010087")]
		[FieldOffset(Offset = "0x8")]
		public string Defeater;

		[Token(Token = "0x4010088")]
		[FieldOffset(Offset = "0xC")]
		public string WeaponDefeatedWith;

		[Token(Token = "0x4010089")]
		[FieldOffset(Offset = "0x10")]
		public bool DefeaterIsZombie;

		[Token(Token = "0x401008A")]
		[FieldOffset(Offset = "0x11")]
		public bool IsShowCsRanking;

		[Token(Token = "0x401008B")]
		[FieldOffset(Offset = "0x14")]
		public uint CsRank;

		[Token(Token = "0x401008C")]
		[FieldOffset(Offset = "0x18")]
		public uint CsRankPoint;

		[Token(Token = "0x401008D")]
		[FieldOffset(Offset = "0x1C")]
		public uint Kills;

		[Token(Token = "0x401008E")]
		[FieldOffset(Offset = "0x20")]
		public uint Damages;

		[Token(Token = "0x401008F")]
		[FieldOffset(Offset = "0x24")]
		public uint SurvivedTime_s;

		[Token(Token = "0x4010090")]
		[FieldOffset(Offset = "0x28")]
		public uint Rank;

		[Token(Token = "0x4010091")]
		[FieldOffset(Offset = "0x2C")]
		public uint TotalPlayersCount;

		[Token(Token = "0x4010092")]
		[FieldOffset(Offset = "0x30")]
		public TeammateData[] Teammates;

		[Token(Token = "0x4010093")]
		[FieldOffset(Offset = "0x34")]
		public uint MatchMode;

		[Token(Token = "0x4010094")]
		[FieldOffset(Offset = "0x38")]
		public uint GameMode;

		[Token(Token = "0x4010095")]
		[FieldOffset(Offset = "0x3C")]
		public uint MapID;

		[Token(Token = "0x4010096")]
		[FieldOffset(Offset = "0x40")]
		public MatchStats MatchStats;

		[Token(Token = "0x6010C09")]
		[Address(RVA = "0x2689204", Offset = "0x2689204", VA = "0x2689204")]
		public MatchResultScreenshotData()
		{
		}
	}

	[Token(Token = "0x401007B")]
	[FieldOffset(Offset = "0x28")]
	private UIMatchResultScreenshotView m_View;

	[Token(Token = "0x401007C")]
	[FieldOffset(Offset = "0x2C")]
	private MatchResultScreenshotData m_Data;

	[Token(Token = "0x401007D")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_PlayerAvatarRenderTexture;

	[Token(Token = "0x401007E")]
	[FieldOffset(Offset = "0x34")]
	private RenderTexture m_ScreenShotRenderTexture;

	[Token(Token = "0x401007F")]
	[FieldOffset(Offset = "0x38")]
	private AvatarManager m_AvatarManager;

	[Token(Token = "0x4010080")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_ViewTeammates;

	[Token(Token = "0x4010081")]
	[FieldOffset(Offset = "0x40")]
	private List<UILabel> m_ViewTeammateNames;

	[Token(Token = "0x4010082")]
	[FieldOffset(Offset = "0x44")]
	private List<UILabel> m_ViewTeammateKills;

	[Token(Token = "0x4010083")]
	[FieldOffset(Offset = "0x48")]
	private UIMatchResultShare3D m_Share3D;

	[Token(Token = "0x4010084")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_originalShadowEnabled;

	[Token(Token = "0x4010085")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<TeammateStats, MatchResultScreenshotData.TeammateData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010086")]
	[FieldOffset(Offset = "0x4")]
	private static Func<MatchResultScreenshotData.TeammateData, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6010BF1")]
	[Address(RVA = "0x2684730", Offset = "0x2684730", VA = "0x2684730")]
	public UIMatchResultScreenshotController()
	{
	}

	[Token(Token = "0x6010BF2")]
	[Address(RVA = "0x26847B4", Offset = "0x26847B4", VA = "0x26847B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010BF3")]
	[Address(RVA = "0x2684858", Offset = "0x2684858", VA = "0x2684858", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010BF4")]
	[Address(RVA = "0x2685498", Offset = "0x2685498", VA = "0x2685498", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010BF5")]
	[Address(RVA = "0x26854FC", Offset = "0x26854FC", VA = "0x26854FC")]
	public void MakeScreenshot(MatchResultScreenshotData data)
	{
	}

	[Token(Token = "0x6010BF6")]
	[Address(RVA = "0x2687BB4", Offset = "0x2687BB4", VA = "0x2687BB4")]
	private string MakeEndgameDescription(uint rank)
	{
		return null;
	}

	[Token(Token = "0x6010BF7")]
	[Address(RVA = "0x26858C8", Offset = "0x26858C8", VA = "0x26858C8")]
	private void UpdatePlayerData()
	{
	}

	[Token(Token = "0x6010BF8")]
	[Address(RVA = "0x2687E74", Offset = "0x2687E74", VA = "0x2687E74")]
	private void UpdateHeadshot()
	{
	}

	[Token(Token = "0x6010BF9")]
	[Address(RVA = "0x2688254", Offset = "0x2688254", VA = "0x2688254")]
	private void UpdateHeadshot(uint iid)
	{
	}

	[Token(Token = "0x6010BFA")]
	[Address(RVA = "0x26883C4", Offset = "0x26883C4", VA = "0x26883C4")]
	private void UpdateHeadshot(HeadPicData data)
	{
	}

	[Token(Token = "0x6010BFB")]
	[Address(RVA = "0x26860D0", Offset = "0x26860D0", VA = "0x26860D0")]
	private void UpdateCsSeasonRank()
	{
	}

	[Token(Token = "0x6010BFC")]
	[Address(RVA = "0x2688548", Offset = "0x2688548", VA = "0x2688548")]
	private void UpdateRankInfo(int rank)
	{
	}

	[Token(Token = "0x6010BFD")]
	[Address(RVA = "0x2686584", Offset = "0x2686584", VA = "0x2686584")]
	private void UpdateSeasonRank()
	{
	}

	[Token(Token = "0x6010BFE")]
	[Address(RVA = "0x2686BF8", Offset = "0x2686BF8", VA = "0x2686BF8")]
	private void UpdateHighlightRank()
	{
	}

	[Token(Token = "0x6010BFF")]
	[Address(RVA = "0x2686DCC", Offset = "0x2686DCC", VA = "0x2686DCC")]
	private void UpdateDetailData()
	{
	}

	[Token(Token = "0x6010C00")]
	[Address(RVA = "0x268734C", Offset = "0x268734C", VA = "0x268734C")]
	private void UpdateGameInfo()
	{
	}

	[Token(Token = "0x6010C01")]
	[Address(RVA = "0x2687614", Offset = "0x2687614", VA = "0x2687614")]
	private void StartRenderPlayerAvatar()
	{
	}

	[Token(Token = "0x6010C02")]
	[Address(RVA = "0x268868C", Offset = "0x268868C", VA = "0x268868C")]
	private void RerenderAfterUMAChanged(UMAData data)
	{
	}

	[Token(Token = "0x6010C03")]
	[Address(RVA = "0x26887C0", Offset = "0x26887C0", VA = "0x26887C0")]
	private void TakeScreenshot()
	{
	}

	[Token(Token = "0x6010C04")]
	[Address(RVA = "0x26889C8", Offset = "0x26889C8", VA = "0x26889C8")]
	private static MatchResultScreenshotData.TeammateData _003CMakeScreenshot_003Em__0(TeammateStats datum)
	{
		return null;
	}

	[Token(Token = "0x6010C05")]
	[Address(RVA = "0x2688A88", Offset = "0x2688A88", VA = "0x2688A88")]
	private static bool _003CMakeScreenshot_003Em__1(MatchResultScreenshotData.TeammateData val)
	{
		return default(bool);
	}

	[Token(Token = "0x6010C06")]
	[Address(RVA = "0x2688BB4", Offset = "0x2688BB4", VA = "0x2688BB4")]
	private void _003CTakeScreenshot_003Em__2()
	{
	}

	[Token(Token = "0x6010C07")]
	[Address(RVA = "0x26891F4", Offset = "0x26891F4", VA = "0x26891F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C08")]
	[Address(RVA = "0x26891FC", Offset = "0x26891FC", VA = "0x26891FC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
