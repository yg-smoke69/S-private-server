using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200286B")]
internal class UIHUDTeamParachuteActionController : UIBaseController
{
	[Token(Token = "0x200286C")]
	private class TransferOption
	{
		[Token(Token = "0x400F944")]
		[FieldOffset(Offset = "0x8")]
		public IHAAMHPPLMG playerId;

		[Token(Token = "0x400F945")]
		[FieldOffset(Offset = "0x20")]
		public int teamIdex;

		[Token(Token = "0x600FD85")]
		[Address(RVA = "0x22207C4", Offset = "0x22207C4", VA = "0x22207C4")]
		public TransferOption(IHAAMHPPLMG pid, int teamidex)
		{
		}
	}

	[Token(Token = "0x200286D")]
	private sealed class _003CUpdateTransferPickupList_003Ec__AnonStorey1
	{
		[Token(Token = "0x400F946")]
		[FieldOffset(Offset = "0x8")]
		internal Player p;

		[Token(Token = "0x600FD86")]
		[Address(RVA = "0x22207BC", Offset = "0x22207BC", VA = "0x22207BC")]
		public _003CUpdateTransferPickupList_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600FD87")]
		[Address(RVA = "0x22210A8", Offset = "0x22210A8", VA = "0x22210A8")]
		internal bool _003C_003Em__0(TransferOption a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200286E")]
	private sealed class _003CHideLeaderPanel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F947")]
		[FieldOffset(Offset = "0x8")]
		internal float seconds;

		[Token(Token = "0x400F948")]
		[FieldOffset(Offset = "0xC")]
		internal UIHUDTeamParachuteActionController _0024this;

		[Token(Token = "0x400F949")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400F94A")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400F94B")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011F7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FD8A")]
			[Address(RVA = "0x2220FFC", Offset = "0x2220FFC", VA = "0x2220FFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011F8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FD8B")]
			[Address(RVA = "0x2221004", Offset = "0x2221004", VA = "0x2221004", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FD88")]
		[Address(RVA = "0x2220DC4", Offset = "0x2220DC4", VA = "0x2220DC4")]
		public _003CHideLeaderPanel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600FD89")]
		[Address(RVA = "0x2220EDC", Offset = "0x2220EDC", VA = "0x2220EDC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FD8C")]
		[Address(RVA = "0x222100C", Offset = "0x222100C", VA = "0x222100C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FD8D")]
		[Address(RVA = "0x2221020", Offset = "0x2221020", VA = "0x2221020", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F93F")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDTeamParachuteActionView m_View;

	[Token(Token = "0x400F940")]
	[FieldOffset(Offset = "0x2C")]
	private IKBGGPAEFDO m_CurMode;

	[Token(Token = "0x400F941")]
	[FieldOffset(Offset = "0x30")]
	private List<TransferOption> m_TransferPickList;

	[Token(Token = "0x400F942")]
	[FieldOffset(Offset = "0x34")]
	private KEMMCPJHGEN m_TeamParachuteManager;

	[Token(Token = "0x400F943")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Player> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600FD70")]
	[Address(RVA = "0x221D140", Offset = "0x221D140", VA = "0x221D140")]
	public UIHUDTeamParachuteActionController()
	{
	}

	[Token(Token = "0x600FD71")]
	[Address(RVA = "0x221D1F8", Offset = "0x221D1F8", VA = "0x221D1F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD72")]
	[Address(RVA = "0x221D2A0", Offset = "0x221D2A0", VA = "0x221D2A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FD73")]
	[Address(RVA = "0x221D740", Offset = "0x221D740", VA = "0x221D740", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FD74")]
	[Address(RVA = "0x221D958", Offset = "0x221D958", VA = "0x221D958")]
	private void ActionButtonDown()
	{
	}

	[Token(Token = "0x600FD75")]
	[Address(RVA = "0x221F9B0", Offset = "0x221F9B0", VA = "0x221F9B0")]
	public void OnModeChange(IKBGGPAEFDO targetMode)
	{
	}

	[Token(Token = "0x600FD76")]
	[Address(RVA = "0x221FA4C", Offset = "0x221FA4C", VA = "0x221FA4C")]
	private void SwitchToFreeUI()
	{
	}

	[Token(Token = "0x600FD77")]
	[Address(RVA = "0x22200A8", Offset = "0x22200A8", VA = "0x22200A8")]
	private void SwitchToFollowUI()
	{
	}

	[Token(Token = "0x600FD78")]
	[Address(RVA = "0x2220260", Offset = "0x2220260", VA = "0x2220260")]
	private void SwitchToLeaderUI()
	{
	}

	[Token(Token = "0x600FD79")]
	[Address(RVA = "0x2220564", Offset = "0x2220564", VA = "0x2220564")]
	private void HideOrShowTransferBtn(object[] data)
	{
	}

	[Token(Token = "0x600FD7A")]
	[Address(RVA = "0x221DC64", Offset = "0x221DC64", VA = "0x221DC64")]
	private void UpdateTransferPickupList()
	{
	}

	[Token(Token = "0x600FD7B")]
	[Address(RVA = "0x221E5FC", Offset = "0x221E5FC", VA = "0x221E5FC")]
	private void RefreshLeaderPanelUI()
	{
	}

	[Token(Token = "0x600FD7C")]
	[Address(RVA = "0x221E470", Offset = "0x221E470", VA = "0x221E470")]
	private void OnBtn1Click()
	{
	}

	[Token(Token = "0x600FD7D")]
	[Address(RVA = "0x2220A9C", Offset = "0x2220A9C", VA = "0x2220A9C")]
	private void OnBtn2Click()
	{
	}

	[Token(Token = "0x600FD7E")]
	[Address(RVA = "0x2220C30", Offset = "0x2220C30", VA = "0x2220C30")]
	private void OnBtn3Click()
	{
	}

	[Token(Token = "0x600FD7F")]
	[Address(RVA = "0x22209A0", Offset = "0x22209A0", VA = "0x22209A0")]
	private IEnumerator HideLeaderPanel(float seconds)
	{
		return null;
	}

	[Token(Token = "0x600FD80")]
	[Address(RVA = "0x2220DCC", Offset = "0x2220DCC", VA = "0x2220DCC")]
	private void onBgBtnClick()
	{
	}

	[Token(Token = "0x600FD81")]
	[Address(RVA = "0x2220814", Offset = "0x2220814", VA = "0x2220814")]
	private void RequestTransferLeader(IHAAMHPPLMG pid)
	{
	}

	[Token(Token = "0x600FD82")]
	[Address(RVA = "0x2220E5C", Offset = "0x2220E5C", VA = "0x2220E5C")]
	private static int _003CUpdateTransferPickupList_003Em__0(Player a, Player b)
	{
		return default(int);
	}

	[Token(Token = "0x600FD83")]
	[Address(RVA = "0x2220ECC", Offset = "0x2220ECC", VA = "0x2220ECC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FD84")]
	[Address(RVA = "0x2220ED4", Offset = "0x2220ED4", VA = "0x2220ED4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
