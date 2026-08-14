using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003304")]
internal class UICOWBaseScene : UIBaseScene
{
	[Token(Token = "0x2003305")]
	public enum WaitFor
	{
		[Token(Token = "0x401361D")]
		Default,
		[Token(Token = "0x401361E")]
		GMSDK,
		[Token(Token = "0x401361F")]
		IAP,
		[Token(Token = "0x4013620")]
		HTTP,
		[Token(Token = "0x4013621")]
		MatchRequest,
		[Token(Token = "0x4013622")]
		MatchResult,
		[Token(Token = "0x4013623")]
		CreateRoom,
		[Token(Token = "0x4013624")]
		TraceRoute,
		[Token(Token = "0x4013625")]
		GoogleEngagementRewards,
		[Token(Token = "0x4013626")]
		LoginLoading
	}

	[Token(Token = "0x2003306")]
	public class Wait
	{
		[Token(Token = "0x4013627")]
		[FieldOffset(Offset = "0x8")]
		public string Log;

		[Token(Token = "0x4013628")]
		[FieldOffset(Offset = "0xC")]
		public bool Block;

		[Token(Token = "0x6015876")]
		[Address(RVA = "0x144BE2C", Offset = "0x144BE2C", VA = "0x144BE2C")]
		public Wait()
		{
		}
	}

	[Token(Token = "0x2003307")]
	private sealed class _003CShowShareImageFileMessageBox_003Ec__AnonStorey3
	{
		[Token(Token = "0x4013629")]
		[FieldOffset(Offset = "0x8")]
		internal Action onClose;

		[Token(Token = "0x401362A")]
		[FieldOffset(Offset = "0xC")]
		internal UIBaseController target;

		[Token(Token = "0x401362B")]
		[FieldOffset(Offset = "0x10")]
		internal UICOWBaseScene _0024this;

		[Token(Token = "0x6015877")]
		[Address(RVA = "0x144AB34", Offset = "0x144AB34", VA = "0x144AB34")]
		public _003CShowShareImageFileMessageBox_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015878")]
		[Address(RVA = "0x144F868", Offset = "0x144F868", VA = "0x144F868")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003308")]
	private sealed class _003C_TakeScreenshot_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x2003309")]
		private sealed class _003C_TakeScreenshot_003Ec__AnonStorey4
		{
			[Token(Token = "0x401363B")]
			[FieldOffset(Offset = "0x8")]
			internal UIImageShareCaptureWidgetController shareCaptureWidget;

			[Token(Token = "0x401363C")]
			[FieldOffset(Offset = "0xC")]
			internal UIBaseController target;

			[Token(Token = "0x401363D")]
			[FieldOffset(Offset = "0x10")]
			internal UIUtils.ScreenshotType screenshotType;

			[Token(Token = "0x401363E")]
			[FieldOffset(Offset = "0x14")]
			internal bool hideUserID;

			[Token(Token = "0x401363F")]
			[FieldOffset(Offset = "0x18")]
			internal string filePath;

			[Token(Token = "0x4013640")]
			[FieldOffset(Offset = "0x1C")]
			internal UIUtils.EShareScreenType screenType;

			[Token(Token = "0x4013641")]
			[FieldOffset(Offset = "0x20")]
			internal bool shareUrl;

			[Token(Token = "0x4013642")]
			[FieldOffset(Offset = "0x24")]
			internal _003C_TakeScreenshot_003Ec__Iterator0 _003C_003Ef__ref_00240;

			[Token(Token = "0x601587F")]
			[Address(RVA = "0x145105C", Offset = "0x145105C", VA = "0x145105C")]
			public _003C_TakeScreenshot_003Ec__AnonStorey4()
			{
			}

			[Token(Token = "0x6015880")]
			[Address(RVA = "0x1451110", Offset = "0x1451110", VA = "0x1451110")]
			internal void _003C_003Em__0(bool saved)
			{
			}
		}

		[Token(Token = "0x401362C")]
		[FieldOffset(Offset = "0x8")]
		internal UIBaseController target;

		[Token(Token = "0x401362D")]
		[FieldOffset(Offset = "0xC")]
		internal bool hasTopBar;

		[Token(Token = "0x401362E")]
		[FieldOffset(Offset = "0xD")]
		internal bool hasLeftBar;

		[Token(Token = "0x401362F")]
		[FieldOffset(Offset = "0x10")]
		internal UIUtils.EShareScreenType screenType;

		[Token(Token = "0x4013630")]
		[FieldOffset(Offset = "0x14")]
		internal float logoScale;

		[Token(Token = "0x4013631")]
		[FieldOffset(Offset = "0x18")]
		internal UIUtils.ScreenshotType screenshotType;

		[Token(Token = "0x4013632")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _003CNeedRotationResultPic_003E__0;

		[Token(Token = "0x4013633")]
		[FieldOffset(Offset = "0x1D")]
		internal bool hideUserID;

		[Token(Token = "0x4013634")]
		[FieldOffset(Offset = "0x20")]
		internal string filePath;

		[Token(Token = "0x4013635")]
		[FieldOffset(Offset = "0x24")]
		internal bool shareUrl;

		[Token(Token = "0x4013636")]
		[FieldOffset(Offset = "0x28")]
		internal UICOWBaseScene _0024this;

		[Token(Token = "0x4013637")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x4013638")]
		[FieldOffset(Offset = "0x30")]
		internal bool _0024disposing;

		[Token(Token = "0x4013639")]
		[FieldOffset(Offset = "0x34")]
		internal int _0024PC;

		[Token(Token = "0x401363A")]
		[FieldOffset(Offset = "0x38")]
		private _003C_TakeScreenshot_003Ec__AnonStorey4 _0024locvar0;

		[Token(Token = "0x170016B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601587B")]
			[Address(RVA = "0x1451064", Offset = "0x1451064", VA = "0x1451064", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601587C")]
			[Address(RVA = "0x145106C", Offset = "0x145106C", VA = "0x145106C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6015879")]
		[Address(RVA = "0x144C640", Offset = "0x144C640", VA = "0x144C640")]
		public _003C_TakeScreenshot_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601587A")]
		[Address(RVA = "0x14508B8", Offset = "0x14508B8", VA = "0x14508B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601587D")]
		[Address(RVA = "0x1451074", Offset = "0x1451074", VA = "0x1451074", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601587E")]
		[Address(RVA = "0x1451088", Offset = "0x1451088", VA = "0x1451088", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200330A")]
	private sealed class _003C_TakeScreenshotAction_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x200330B")]
		private sealed class _003C_TakeScreenshotAction_003Ec__AnonStorey5
		{
			[Token(Token = "0x4013652")]
			[FieldOffset(Offset = "0x8")]
			internal UIImageShareCaptureWidgetController shareCaptureWidget;

			[Token(Token = "0x4013653")]
			[FieldOffset(Offset = "0xC")]
			internal UIBaseController target;

			[Token(Token = "0x4013654")]
			[FieldOffset(Offset = "0x10")]
			internal UIUtils.ScreenshotType screenshotType;

			[Token(Token = "0x4013655")]
			[FieldOffset(Offset = "0x14")]
			internal bool hideUserID;

			[Token(Token = "0x4013656")]
			[FieldOffset(Offset = "0x18")]
			internal string filePath;

			[Token(Token = "0x4013657")]
			[FieldOffset(Offset = "0x1C")]
			internal UIUtils.EShareScreenType screenType;

			[Token(Token = "0x4013658")]
			[FieldOffset(Offset = "0x20")]
			internal Action onClose;

			[Token(Token = "0x4013659")]
			[FieldOffset(Offset = "0x24")]
			internal bool shareUrl;

			[Token(Token = "0x401365A")]
			[FieldOffset(Offset = "0x28")]
			internal _003C_TakeScreenshotAction_003Ec__Iterator1 _003C_003Ef__ref_00241;

			[Token(Token = "0x6015887")]
			[Address(RVA = "0x1451D00", Offset = "0x1451D00", VA = "0x1451D00")]
			public _003C_TakeScreenshotAction_003Ec__AnonStorey5()
			{
			}

			[Token(Token = "0x6015888")]
			[Address(RVA = "0x1451DB4", Offset = "0x1451DB4", VA = "0x1451DB4")]
			internal void _003C_003Em__0(bool saved)
			{
			}
		}

		[Token(Token = "0x4013643")]
		[FieldOffset(Offset = "0x8")]
		internal UIBaseController target;

		[Token(Token = "0x4013644")]
		[FieldOffset(Offset = "0xC")]
		internal bool hasTopBar;

		[Token(Token = "0x4013645")]
		[FieldOffset(Offset = "0xD")]
		internal bool hasLeftBar;

		[Token(Token = "0x4013646")]
		[FieldOffset(Offset = "0x10")]
		internal UIUtils.EShareScreenType screenType;

		[Token(Token = "0x4013647")]
		[FieldOffset(Offset = "0x14")]
		internal bool _003CNeedRotationResultPic_003E__0;

		[Token(Token = "0x4013648")]
		[FieldOffset(Offset = "0x18")]
		internal UIUtils.ScreenshotType screenshotType;

		[Token(Token = "0x4013649")]
		[FieldOffset(Offset = "0x1C")]
		internal bool hideUserID;

		[Token(Token = "0x401364A")]
		[FieldOffset(Offset = "0x20")]
		internal string filePath;

		[Token(Token = "0x401364B")]
		[FieldOffset(Offset = "0x24")]
		internal Action onClose;

		[Token(Token = "0x401364C")]
		[FieldOffset(Offset = "0x28")]
		internal bool shareUrl;

		[Token(Token = "0x401364D")]
		[FieldOffset(Offset = "0x2C")]
		internal UICOWBaseScene _0024this;

		[Token(Token = "0x401364E")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x401364F")]
		[FieldOffset(Offset = "0x34")]
		internal bool _0024disposing;

		[Token(Token = "0x4013650")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x4013651")]
		[FieldOffset(Offset = "0x3C")]
		private _003C_TakeScreenshotAction_003Ec__AnonStorey5 _0024locvar0;

		[Token(Token = "0x170016BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6015883")]
			[Address(RVA = "0x1451D08", Offset = "0x1451D08", VA = "0x1451D08", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6015884")]
			[Address(RVA = "0x1451D10", Offset = "0x1451D10", VA = "0x1451D10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6015881")]
		[Address(RVA = "0x144CA1C", Offset = "0x144CA1C", VA = "0x144CA1C")]
		public _003C_TakeScreenshotAction_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6015882")]
		[Address(RVA = "0x145156C", Offset = "0x145156C", VA = "0x145156C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6015885")]
		[Address(RVA = "0x1451D18", Offset = "0x1451D18", VA = "0x1451D18", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6015886")]
		[Address(RVA = "0x1451D2C", Offset = "0x1451D2C", VA = "0x1451D2C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200330C")]
	private sealed class _003C_TakeScreenShotWithoutSave_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x200330D")]
		private sealed class _003C_TakeScreenShotWithoutSave_003Ec__AnonStorey6
		{
			[Token(Token = "0x4013667")]
			[FieldOffset(Offset = "0x8")]
			internal RenderTexture renderTexture;

			[Token(Token = "0x4013668")]
			[FieldOffset(Offset = "0xC")]
			internal bool NeedRotationResultPic;

			[Token(Token = "0x4013669")]
			[FieldOffset(Offset = "0x10")]
			internal Action<Texture2D> onScreenShotFinish;

			[Token(Token = "0x401366A")]
			[FieldOffset(Offset = "0x14")]
			internal UIImageShareCaptureWidgetController shareCaptureWidget;

			[Token(Token = "0x401366B")]
			[FieldOffset(Offset = "0x18")]
			internal UIBaseController target;

			[Token(Token = "0x401366C")]
			[FieldOffset(Offset = "0x1C")]
			internal UIUtils.ScreenshotType screenshotType;

			[Token(Token = "0x401366D")]
			[FieldOffset(Offset = "0x20")]
			internal bool hideUserID;

			[Token(Token = "0x401366E")]
			[FieldOffset(Offset = "0x24")]
			internal _003C_TakeScreenShotWithoutSave_003Ec__Iterator2 _003C_003Ef__ref_00242;

			[Token(Token = "0x601588F")]
			[Address(RVA = "0x145005C", Offset = "0x145005C", VA = "0x145005C")]
			public _003C_TakeScreenShotWithoutSave_003Ec__AnonStorey6()
			{
			}

			[Token(Token = "0x6015890")]
			[Address(RVA = "0x1450110", Offset = "0x1450110", VA = "0x1450110")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x401365B")]
		[FieldOffset(Offset = "0x8")]
		internal UIBaseController target;

		[Token(Token = "0x401365C")]
		[FieldOffset(Offset = "0xC")]
		internal bool hasTopBar;

		[Token(Token = "0x401365D")]
		[FieldOffset(Offset = "0xD")]
		internal bool hasLeftBar;

		[Token(Token = "0x401365E")]
		[FieldOffset(Offset = "0x10")]
		internal UIUtils.EShareScreenType screenType;

		[Token(Token = "0x401365F")]
		[FieldOffset(Offset = "0x14")]
		internal UIUtils.ScreenshotType screenshotType;

		[Token(Token = "0x4013660")]
		[FieldOffset(Offset = "0x18")]
		internal bool hideUserID;

		[Token(Token = "0x4013661")]
		[FieldOffset(Offset = "0x1C")]
		internal Action<Texture2D> onScreenShotFinish;

		[Token(Token = "0x4013662")]
		[FieldOffset(Offset = "0x20")]
		internal UICOWBaseScene _0024this;

		[Token(Token = "0x4013663")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4013664")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4013665")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x4013666")]
		[FieldOffset(Offset = "0x30")]
		private _003C_TakeScreenShotWithoutSave_003Ec__AnonStorey6 _0024locvar0;

		[Token(Token = "0x170016BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601588B")]
			[Address(RVA = "0x1450064", Offset = "0x1450064", VA = "0x1450064", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601588C")]
			[Address(RVA = "0x145006C", Offset = "0x145006C", VA = "0x145006C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6015889")]
		[Address(RVA = "0x144CD98", Offset = "0x144CD98", VA = "0x144CD98")]
		public _003C_TakeScreenShotWithoutSave_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x601588A")]
		[Address(RVA = "0x144F8D0", Offset = "0x144F8D0", VA = "0x144F8D0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601588D")]
		[Address(RVA = "0x1450074", Offset = "0x1450074", VA = "0x1450074", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601588E")]
		[Address(RVA = "0x1450088", Offset = "0x1450088", VA = "0x1450088", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4013611")]
	[FieldOffset(Offset = "0x34")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x4013612")]
	[FieldOffset(Offset = "0x38")]
	private UIModelInvitation m_ModelInvitation;

	[Token(Token = "0x4013613")]
	[FieldOffset(Offset = "0x3C")]
	private UIWaitingForRequestController m_WaitingForRequestController;

	[Token(Token = "0x4013614")]
	[FieldOffset(Offset = "0x40")]
	private UIWaitingForRequestCircleController m_WaitingForRequestCircleController;

	[Token(Token = "0x4013615")]
	[FieldOffset(Offset = "0x44")]
	private UIPopupMessageBoxController m_PopupMessageController;

	[Token(Token = "0x4013616")]
	[FieldOffset(Offset = "0x48")]
	public UIImageSharePreviewWindowController m_ImageSharePreviewWindowController;

	[Token(Token = "0x4013617")]
	[FieldOffset(Offset = "0x4C")]
	protected UIMaskController m_MaskController;

	[Token(Token = "0x4013618")]
	[FieldOffset(Offset = "0x50")]
	protected UIMaskController m_MaskBelowUICtrl;

	[Token(Token = "0x4013619")]
	[FieldOffset(Offset = "0x54")]
	protected UIInvitationTipsBoxController m_CurInviteTipsController;

	[Token(Token = "0x401361A")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, Wait> _Waits;

	[Token(Token = "0x401361B")]
	[FieldOffset(Offset = "0x5C")]
	private UINewVaultController newVaultCtr;

	[Token(Token = "0x170016B6")]
	protected UIModelClan ModelClan
	{
		[Token(Token = "0x6015851")]
		[Address(RVA = "0x144A1DC", Offset = "0x144A1DC", VA = "0x144A1DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B7")]
	protected UIModelInvitation ModelInvitation
	{
		[Token(Token = "0x6015852")]
		[Address(RVA = "0x144A2EC", Offset = "0x144A2EC", VA = "0x144A2EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B8")]
	public bool ShowingShareImageFileMessageBox
	{
		[Token(Token = "0x6015856")]
		[Address(RVA = "0x144A754", Offset = "0x144A754", VA = "0x144A754")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6015850")]
	[Address(RVA = "0x144A0EC", Offset = "0x144A0EC", VA = "0x144A0EC")]
	public UICOWBaseScene()
	{
	}

	[Token(Token = "0x6015853")]
	[Address(RVA = "0x144A3FC", Offset = "0x144A3FC", VA = "0x144A3FC", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015854")]
	[Address(RVA = "0x144A460", Offset = "0x144A460", VA = "0x144A460", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015855")]
	[Address(RVA = "0x144A538", Offset = "0x144A538", VA = "0x144A538")]
	public void ShowStandardMessageBox(string info, UIPopupMessageBoxController.EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.OKOnly, string note = "", string okTextKey = "", [Optional] Func<bool> confirmDelayCallFunc)
	{
	}

	[Token(Token = "0x6015857")]
	[Address(RVA = "0x144A828", Offset = "0x144A828", VA = "0x144A828")]
	public void ShowShareImageFileMessageBox(UIBaseController target, ShareImageData data, [Optional] Action onClose, uint changedepth = 0u, bool shareUrl = false)
	{
	}

	[Token(Token = "0x6015858")]
	[Address(RVA = "0x144AB3C", Offset = "0x144AB3C", VA = "0x144AB3C")]
	public void ShowNetworkErrorMessageBox()
	{
	}

	[Token(Token = "0x6015859")]
	[Address(RVA = "0x144ACE4", Offset = "0x144ACE4", VA = "0x144ACE4")]
	public Wait GetWait(WaitFor reason)
	{
		return null;
	}

	[Token(Token = "0x601585A")]
	[Address(RVA = "0x144ADF0", Offset = "0x144ADF0", VA = "0x144ADF0")]
	public int GetWaitingCout()
	{
		return default(int);
	}

	[Token(Token = "0x601585B")]
	[Address(RVA = "0x144AEB0", Offset = "0x144AEB0", VA = "0x144AEB0")]
	public void ShowWaiting(WaitFor reason, Wait wait, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601585C")]
	[Address(RVA = "0x144BA2C", Offset = "0x144BA2C", VA = "0x144BA2C")]
	public void HideWaiting(WaitFor reason)
	{
	}

	[Token(Token = "0x601585D")]
	[Address(RVA = "0x144BAB4", Offset = "0x144BAB4", VA = "0x144BAB4")]
	public void PrintWaiting()
	{
	}

	[Token(Token = "0x601585E")]
	[Address(RVA = "0x144AF44", Offset = "0x144AF44", VA = "0x144AF44")]
	private void _SetWaitingUI(bool value, WaitFor reason, Wait wait, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601585F")]
	[Address(RVA = "0x144BE34", Offset = "0x144BE34", VA = "0x144BE34")]
	public bool HasPopupBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6015860")]
	[Address(RVA = "0x144BF08", Offset = "0x144BF08", VA = "0x144BF08")]
	public void ClosePopupBox()
	{
	}

	[Token(Token = "0x6015861")]
	[Address(RVA = "0x144C00C", Offset = "0x144C00C", VA = "0x144C00C")]
	public void SetMask(bool mask, Color color)
	{
	}

	[Token(Token = "0x6015862")]
	public override T PushNavigation<T>(UINavigationData navigationData, bool isRoot = false)
	{
		return null;
	}

	[Token(Token = "0x6015863")]
	[Address(RVA = "0x144C25C", Offset = "0x144C25C", VA = "0x144C25C")]
	public void TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false, bool shareUrl = false)
	{
	}

	[Token(Token = "0x6015864")]
	[Address(RVA = "0x144C444", Offset = "0x144C444", VA = "0x144C444")]
	private IEnumerator _TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false, bool shareUrl = false)
	{
		return null;
	}

	[Token(Token = "0x6015865")]
	[Address(RVA = "0x144C648", Offset = "0x144C648", VA = "0x144C648")]
	public void TakeScreenshotWithAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, [Optional] Action onClose, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false)
	{
	}

	[Token(Token = "0x6015866")]
	[Address(RVA = "0x144C824", Offset = "0x144C824", VA = "0x144C824")]
	private IEnumerator _TakeScreenshotAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, [Optional] Action onClose, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false)
	{
		return null;
	}

	[Token(Token = "0x6015867")]
	[Address(RVA = "0x144CA24", Offset = "0x144CA24", VA = "0x144CA24")]
	public void TakeScreenShotWithoutSave(UIUtils.ScreenshotType screenshotType, UIBaseController target, Action<Texture2D> onScreenShotFinish, bool hasTopBar = true, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false, bool shareUrl = false)
	{
	}

	[Token(Token = "0x6015868")]
	[Address(RVA = "0x144CBE0", Offset = "0x144CBE0", VA = "0x144CBE0")]
	private IEnumerator _TakeScreenShotWithoutSave(UIUtils.ScreenshotType screenshotType, UIBaseController target, Action<Texture2D> onScreenShotFinish, bool hasTopBar, bool hasLeftBar, UIUtils.EShareScreenType screenType, bool hideUserID, bool shareUrl)
	{
		return null;
	}

	[Token(Token = "0x6015869")]
	[Address(RVA = "0x144CDA0", Offset = "0x144CDA0", VA = "0x144CDA0", Slot = "14")]
	protected virtual bool OnCheckInviteNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x601586A")]
	[Address(RVA = "0x144CDF8", Offset = "0x144CDF8", VA = "0x144CDF8")]
	protected void OnInviteNtf(object[] data)
	{
	}

	[Token(Token = "0x601586B")]
	[Address(RVA = "0x144D090", Offset = "0x144D090", VA = "0x144D090")]
	protected void OnAcceptJoinNtf(object[] data)
	{
	}

	[Token(Token = "0x601586C")]
	[Address(RVA = "0x144D388", Offset = "0x144D388", VA = "0x144D388")]
	protected void SendInviteNotiReplaceLog(object data)
	{
	}

	[Token(Token = "0x601586D")]
	[Address(RVA = "0x144CF2C", Offset = "0x144CF2C", VA = "0x144CF2C")]
	protected void ProcessInviteTip(object[] data)
	{
	}

	[Token(Token = "0x601586E")]
	[Address(RVA = "0x144D3E4", Offset = "0x144D3E4", VA = "0x144D3E4")]
	protected void ProcessInviteTipImmediately(object[] data)
	{
	}

	[Token(Token = "0x601586F")]
	[Address(RVA = "0x144F23C", Offset = "0x144F23C", VA = "0x144F23C")]
	protected void OpenInvitationTipsBox(object[] args)
	{
	}

	[Token(Token = "0x6015870")]
	[Address(RVA = "0x144F4BC", Offset = "0x144F4BC", VA = "0x144F4BC")]
	protected void OnInvitationTipsClose(object[] data)
	{
	}

	[Token(Token = "0x6015871")]
	[Address(RVA = "0x144F520", Offset = "0x144F520", VA = "0x144F520")]
	public bool CheckInviteTipsIsOn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015872")]
	[Address(RVA = "0x144F018", Offset = "0x144F018", VA = "0x144F018")]
	private bool CheckUGCAcceptFriendInvite(ulong account_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6015873")]
	[Address(RVA = "0x144F5F4", Offset = "0x144F5F4", VA = "0x144F5F4")]
	public void Test_GamingNewVault()
	{
	}

	[Token(Token = "0x6015874")]
	[Address(RVA = "0x144F858", Offset = "0x144F858", VA = "0x144F858")]
	public void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015875")]
	[Address(RVA = "0x144F860", Offset = "0x144F860", VA = "0x144F860")]
	public void _003C_003EiFixBaseProxy_OnInit()
	{
	}
}
