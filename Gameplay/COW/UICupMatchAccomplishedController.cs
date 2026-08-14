using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200205F")]
public class UICupMatchAccomplishedController : UIBaseController
{
	[Token(Token = "0x2002060")]
	private sealed class _003CRefreshTeamView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CAF8")]
		[FieldOffset(Offset = "0x8")]
		internal CupTeamInfo cupTeamInfo;

		[Token(Token = "0x600A589")]
		[Address(RVA = "0x273C564", Offset = "0x273C564", VA = "0x273C564")]
		public _003CRefreshTeamView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A58A")]
		[Address(RVA = "0x273C860", Offset = "0x273C860", VA = "0x273C860")]
		internal bool _003C_003Em__0(UIModelCupMatch.AccountInfoBasicWithCupInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CAEE")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchAccomplishedView m_View;

	[Token(Token = "0x400CAEF")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x400CAF0")]
	[FieldOffset(Offset = "0x30")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CAF1")]
	[FieldOffset(Offset = "0x34")]
	private string m_CupCDNPath;

	[Token(Token = "0x400CAF2")]
	[FieldOffset(Offset = "0x38")]
	private string m_SquadName;

	[Token(Token = "0x400CAF3")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CupName;

	[Token(Token = "0x400CAF4")]
	[FieldOffset(Offset = "0x40")]
	private string m_TierLevel;

	[Token(Token = "0x400CAF5")]
	[FieldOffset(Offset = "0x44")]
	private Transform[] m_ProfileContainerList;

	[Token(Token = "0x400CAF6")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchProfileItemController[] m_ProfileCtrlList;

	[Token(Token = "0x400CAF7")]
	private const float SCREENSHOT_DELAY = 0.5f;

	[Token(Token = "0x600A582")]
	[Address(RVA = "0x273B4C4", Offset = "0x273B4C4", VA = "0x273B4C4")]
	public UICupMatchAccomplishedController()
	{
	}

	[Token(Token = "0x600A583")]
	[Address(RVA = "0x273B548", Offset = "0x273B548", VA = "0x273B548")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A584")]
	[Address(RVA = "0x273B5F0", Offset = "0x273B5F0", VA = "0x273B5F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A585")]
	[Address(RVA = "0x273BA3C", Offset = "0x273BA3C", VA = "0x273BA3C")]
	public void SetViewData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A586")]
	[Address(RVA = "0x273BED0", Offset = "0x273BED0", VA = "0x273BED0")]
	public void RefreshTeamView()
	{
	}

	[Token(Token = "0x600A587")]
	[Address(RVA = "0x273C56C", Offset = "0x273C56C", VA = "0x273C56C")]
	private void OnBtnShareClick()
	{
	}

	[Token(Token = "0x600A588")]
	[Address(RVA = "0x273C858", Offset = "0x273C858", VA = "0x273C858")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
