using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20027B3")]
internal class UIHudMatchResultBaseShareController : UIBaseController, _Attribute
{
	[Token(Token = "0x20027B4")]
	private sealed class _003CWaitAndReturnToLobby_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F513")]
		[FieldOffset(Offset = "0x8")]
		internal float secs;

		[Token(Token = "0x400F514")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudMatchResultBaseShareController _0024this;

		[Token(Token = "0x400F515")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400F516")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400F517")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F530")]
			[Address(RVA = "0x19B0EDC", Offset = "0x19B0EDC", VA = "0x19B0EDC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F531")]
			[Address(RVA = "0x19B0EE4", Offset = "0x19B0EE4", VA = "0x19B0EE4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F52E")]
		[Address(RVA = "0x19B0DCC", Offset = "0x19B0DCC", VA = "0x19B0DCC")]
		public _003CWaitAndReturnToLobby_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F52F")]
		[Address(RVA = "0x19B0DE4", Offset = "0x19B0DE4", VA = "0x19B0DE4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F532")]
		[Address(RVA = "0x19B0EEC", Offset = "0x19B0EEC", VA = "0x19B0EEC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F533")]
		[Address(RVA = "0x19B0F00", Offset = "0x19B0F00", VA = "0x19B0F00", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F509")]
	[FieldOffset(Offset = "0x28")]
	protected UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F50A")]
	[FieldOffset(Offset = "0x2C")]
	protected MatchStats m_MatchStats;

	[Token(Token = "0x400F50B")]
	[FieldOffset(Offset = "0x30")]
	protected MatchIncome m_MatchIncome;

	[Token(Token = "0x400F50C")]
	[FieldOffset(Offset = "0x34")]
	protected bool m_UseNewShare;

	[Token(Token = "0x400F50D")]
	[FieldOffset(Offset = "0x35")]
	protected bool m_ScreenshotShareInited;

	[Token(Token = "0x400F50E")]
	[FieldOffset(Offset = "0x38")]
	private string m_ScreenshotFilePath;

	[Token(Token = "0x400F50F")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsHaveShareFile;

	[Token(Token = "0x400F510")]
	[FieldOffset(Offset = "0x40")]
	private UIMatchResultScreenshotController.MatchResultScreenshotData m_ScreenShotData;

	[Token(Token = "0x400F511")]
	[FieldOffset(Offset = "0x44")]
	private Coroutine m_AutoReturnToLobbyCor;

	[Token(Token = "0x400F512")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine m_AutoReturnCommonMatchResultCor;

	[Token(Token = "0x600F516")]
	[Address(RVA = "0x19AF0C8", Offset = "0x19AF0C8", VA = "0x19AF0C8")]
	public UIHudMatchResultBaseShareController()
	{
	}

	[Token(Token = "0x600F517")]
	[Address(RVA = "0x19AF194", Offset = "0x19AF194", VA = "0x19AF194", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F518")]
	[Address(RVA = "0x19AF31C", Offset = "0x19AF31C", VA = "0x19AF31C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F519")]
	[Address(RVA = "0x19AF4E8", Offset = "0x19AF4E8", VA = "0x19AF4E8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F51A")]
	[Address(RVA = "0x19AF58C", Offset = "0x19AF58C", VA = "0x19AF58C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F51B")]
	[Address(RVA = "0x19AF830", Offset = "0x19AF830", VA = "0x19AF830", Slot = "33")]
	protected virtual void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x600F51C")]
	[Address(RVA = "0x19AF8A0", Offset = "0x19AF8A0", VA = "0x19AF8A0")]
	protected void InitScreenShotShare(UIButton btn)
	{
	}

	[Token(Token = "0x600F51D")]
	[Address(RVA = "0x19AFA74", Offset = "0x19AFA74", VA = "0x19AFA74")]
	private void RegisterScreenShotShareEvetns()
	{
	}

	[Token(Token = "0x600F51E")]
	[Address(RVA = "0x19AF39C", Offset = "0x19AF39C", VA = "0x19AF39C")]
	private void UnregisterScreenShotShareEvetns()
	{
	}

	[Token(Token = "0x600F51F")]
	[Address(RVA = "0x19AFBC0", Offset = "0x19AFBC0", VA = "0x19AFBC0")]
	protected void DisableCameraFlareLayer()
	{
	}

	[Token(Token = "0x600F520")]
	[Address(RVA = "0x19AFDE8", Offset = "0x19AFDE8", VA = "0x19AFDE8", Slot = "34")]
	protected virtual void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600F521")]
	[Address(RVA = "0x19B0114", Offset = "0x19B0114", VA = "0x19B0114")]
	private void MakeShareImage()
	{
	}

	[Token(Token = "0x600F522")]
	[Address(RVA = "0x19B0404", Offset = "0x19B0404", VA = "0x19B0404", Slot = "35")]
	protected virtual UIMatchResultScreenshotController.MatchResultScreenshotData CreateScreenShotData()
	{
		return null;
	}

	[Token(Token = "0x600F523")]
	[Address(RVA = "0x19B06A8", Offset = "0x19B06A8", VA = "0x19B06A8", Slot = "36")]
	protected virtual bool HasDefeater(MatchStats stats)
	{
		return default(bool);
	}

	[Token(Token = "0x600F524")]
	[Address(RVA = "0x19B07B0", Offset = "0x19B07B0", VA = "0x19B07B0")]
	private void OnScreenshotResponse(object[] param)
	{
	}

	[Token(Token = "0x600F525")]
	[Address(RVA = "0x19B029C", Offset = "0x19B029C", VA = "0x19B029C")]
	private void ShowSharePanel()
	{
	}

	[Token(Token = "0x600F526")]
	[Address(RVA = "0x19B097C", Offset = "0x19B097C", VA = "0x19B097C")]
	protected void InitReturnButton(UIButton btn)
	{
	}

	[Token(Token = "0x600F527")]
	[Address(RVA = "0x19B0AA8", Offset = "0x19B0AA8", VA = "0x19B0AA8", Slot = "37")]
	protected virtual void ReturnToLobby()
	{
	}

	[Token(Token = "0x600F528")]
	[Address(RVA = "0x19B0C50", Offset = "0x19B0C50", VA = "0x19B0C50")]
	protected void StartAutoReturnToLobby(float secs)
	{
	}

	[Token(Token = "0x600F529")]
	[Address(RVA = "0x19B0024", Offset = "0x19B0024", VA = "0x19B0024")]
	protected void StopAutoReturnToLobby()
	{
	}

	[Token(Token = "0x600F52A")]
	[Address(RVA = "0x19B009C", Offset = "0x19B009C", VA = "0x19B009C")]
	protected void StopAutoReturnToCommonMatchResult()
	{
	}

	[Token(Token = "0x600F52B")]
	[Address(RVA = "0x19B0CD0", Offset = "0x19B0CD0", VA = "0x19B0CD0")]
	protected IEnumerator WaitAndReturnToLobby(float secs)
	{
		return null;
	}

	[Token(Token = "0x600F52C")]
	[Address(RVA = "0x19B0DD4", Offset = "0x19B0DD4", VA = "0x19B0DD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F52D")]
	[Address(RVA = "0x19B0DDC", Offset = "0x19B0DDC", VA = "0x19B0DDC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
