using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002028")]
public class UIChampionshipTeamProfileController : UIBaseController
{
	[Token(Token = "0x2002029")]
	public enum ContentType
	{
		[Token(Token = "0x400C9F2")]
		Memebers,
		[Token(Token = "0x400C9F3")]
		Record
	}

	[Token(Token = "0x200202A")]
	public class InfoEasyListFactory : _Attribute
	{
		[Token(Token = "0x400C9F4")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipTeamProfileController teamProfile;

		[Token(Token = "0x400C9F5")]
		[FieldOffset(Offset = "0xC")]
		public bool ShowPresence;

		[Token(Token = "0x400C9F6")]
		[FieldOffset(Offset = "0xD")]
		public bool ShowPopupMenu;

		[Token(Token = "0x600A31C")]
		[Address(RVA = "0x261B170", Offset = "0x261B170", VA = "0x261B170")]
		public InfoEasyListFactory(UIChampionshipTeamProfileController teamProfile)
		{
		}

		[Token(Token = "0x600A31D")]
		[Address(RVA = "0x261BF44", Offset = "0x261BF44", VA = "0x261BF44", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A31E")]
		[Address(RVA = "0x261BFC0", Offset = "0x261BFC0", VA = "0x261BFC0", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x200202B")]
	public class RecordEasyListFactory : _Attribute
	{
		[Token(Token = "0x400C9F7")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipTeamProfileController teamProfile;

		[Token(Token = "0x600A31F")]
		[Address(RVA = "0x261B19C", Offset = "0x261B19C", VA = "0x261B19C")]
		public RecordEasyListFactory(UIChampionshipTeamProfileController teamProfile)
		{
		}

		[Token(Token = "0x600A320")]
		[Address(RVA = "0x261C0CC", Offset = "0x261C0CC", VA = "0x261C0CC", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A321")]
		[Address(RVA = "0x261C148", Offset = "0x261C148", VA = "0x261C148", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400C9E9")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipTeamProfileView m_View;

	[Token(Token = "0x400C9EA")]
	[FieldOffset(Offset = "0x2C")]
	protected InfoEasyListFactory m_InfoEasyListFactory;

	[Token(Token = "0x400C9EB")]
	[FieldOffset(Offset = "0x30")]
	protected RecordEasyListFactory m_RecordEasyListFactory;

	[Token(Token = "0x400C9EC")]
	[FieldOffset(Offset = "0x34")]
	protected Dictionary<int, GameObject> m_ContentUIs;

	[Token(Token = "0x400C9ED")]
	[FieldOffset(Offset = "0x38")]
	protected UIChampionshipTeamOverviewController m_TeamOverviewUI;

	[Token(Token = "0x400C9EE")]
	[FieldOffset(Offset = "0x3C")]
	public List<TeamChampionshipMatchData> m_MatchData;

	[Token(Token = "0x400C9EF")]
	[FieldOffset(Offset = "0x40")]
	protected uint m_ChampionshipType;

	[Token(Token = "0x400C9F0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeamChampionshipMatchData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A312")]
	[Address(RVA = "0x261AACC", Offset = "0x261AACC", VA = "0x261AACC")]
	public UIChampionshipTeamProfileController()
	{
	}

	[Token(Token = "0x600A313")]
	[Address(RVA = "0x261ABB8", Offset = "0x261ABB8", VA = "0x261ABB8")]
	public static ResourceID UIResource()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A314")]
	[Address(RVA = "0x261AC5C", Offset = "0x261AC5C", VA = "0x261AC5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A315")]
	[Address(RVA = "0x261B1BC", Offset = "0x261B1BC", VA = "0x261B1BC")]
	protected object GetView()
	{
		return null;
	}

	[Token(Token = "0x600A316")]
	public T OpenChild<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x600A317")]
	[Address(RVA = "0x261B214", Offset = "0x261B214", VA = "0x261B214")]
	public void UpdateTeamMemberView(TeamInfo teamInfo, List<TeamMemberWithAccountInfo> members, bool sortPresence = false)
	{
	}

	[Token(Token = "0x600A318")]
	[Address(RVA = "0x261B3D4", Offset = "0x261B3D4", VA = "0x261B3D4")]
	public void UpdateRecordView(ulong teamID, List<TeamChampionshipMatchStats> matchStats)
	{
	}

	[Token(Token = "0x600A319")]
	[Address(RVA = "0x261BC3C", Offset = "0x261BC3C", VA = "0x261BC3C")]
	protected void UpdateContentUI(ContentType contentType)
	{
	}

	[Token(Token = "0x600A31A")]
	[Address(RVA = "0x261BE88", Offset = "0x261BE88", VA = "0x261BE88")]
	private static int _003CUpdateRecordView_003Em__0(TeamChampionshipMatchData a, TeamChampionshipMatchData b)
	{
		return default(int);
	}

	[Token(Token = "0x600A31B")]
	[Address(RVA = "0x261BF3C", Offset = "0x261BF3C", VA = "0x261BF3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
