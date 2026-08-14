using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023A0")]
public class UIHudIngameSingerMusicMiniGamePhaseThreeController : UIBaseController
{
	[Token(Token = "0x20023A1")]
	private sealed class _003CMusicGameBeginCountDown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DDED")]
		[FieldOffset(Offset = "0x8")]
		internal WaitForSecondsRealtime _003CwaitOneSecond_003E__0;

		[Token(Token = "0x400DDEE")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CcountDownTime_003E__0;

		[Token(Token = "0x400DDEF")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudIngameSingerMusicMiniGamePhaseThreeController _0024this;

		[Token(Token = "0x400DDF0")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400DDF1")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400DDF2")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170010DE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C84C")]
			[Address(RVA = "0x22A97C4", Offset = "0x22A97C4", VA = "0x22A97C4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010DF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C84D")]
			[Address(RVA = "0x22A97CC", Offset = "0x22A97CC", VA = "0x22A97CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C84A")]
		[Address(RVA = "0x22A77D0", Offset = "0x22A77D0", VA = "0x22A77D0")]
		public _003CMusicGameBeginCountDown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C84B")]
		[Address(RVA = "0x22A965C", Offset = "0x22A965C", VA = "0x22A965C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C84E")]
		[Address(RVA = "0x22A97D4", Offset = "0x22A97D4", VA = "0x22A97D4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C84F")]
		[Address(RVA = "0x22A97E8", Offset = "0x22A97E8", VA = "0x22A97E8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DDE4")]
	[FieldOffset(Offset = "0x0")]
	private static int toneUIDCreate;

	[Token(Token = "0x400DDE5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudIngameSingerMusicMiniGamePhaseThreeView m_view;

	[Token(Token = "0x400DDE6")]
	[FieldOffset(Offset = "0x2C")]
	private MusicMiniGamePhaseThreeGameData m_data;

	[Token(Token = "0x400DDE7")]
	[FieldOffset(Offset = "0x30")]
	private bool hasStartMusicGame;

	[Token(Token = "0x400DDE8")]
	[FieldOffset(Offset = "0x34")]
	private int gameID;

	[Token(Token = "0x400DDE9")]
	[FieldOffset(Offset = "0x38")]
	private List<SingerMiniMusicGamePhaseThreeConfigData> toneConfigList;

	[Token(Token = "0x400DDEA")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, Tone> toneObjDic;

	[Token(Token = "0x400DDEB")]
	[FieldOffset(Offset = "0x40")]
	private bool isShow;

	[Token(Token = "0x400DDEC")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<SingerMiniMusicGamePhaseThreeConfigData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C832")]
	[Address(RVA = "0x22A73B8", Offset = "0x22A73B8", VA = "0x22A73B8")]
	public UIHudIngameSingerMusicMiniGamePhaseThreeController()
	{
	}

	[Token(Token = "0x600C833")]
	[Address(RVA = "0x22A74AC", Offset = "0x22A74AC", VA = "0x22A74AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C834")]
	[Address(RVA = "0x22A7554", Offset = "0x22A7554", VA = "0x22A7554")]
	public void MusicGameBegin(int gameID)
	{
	}

	[Token(Token = "0x600C835")]
	[Address(RVA = "0x22A7704", Offset = "0x22A7704", VA = "0x22A7704")]
	private IEnumerator MusicGameBeginCountDown()
	{
		return null;
	}

	[Token(Token = "0x600C836")]
	[Address(RVA = "0x22A77D8", Offset = "0x22A77D8", VA = "0x22A77D8")]
	private void RealMusicGameBegin()
	{
	}

	[Token(Token = "0x600C837")]
	[Address(RVA = "0x22A7DE8", Offset = "0x22A7DE8", VA = "0x22A7DE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C838")]
	[Address(RVA = "0x22A7FC8", Offset = "0x22A7FC8", VA = "0x22A7FC8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C839")]
	[Address(RVA = "0x22A80FC", Offset = "0x22A80FC", VA = "0x22A80FC", Slot = "23")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600C83A")]
	[Address(RVA = "0x22A8154", Offset = "0x22A8154", VA = "0x22A8154", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600C83B")]
	[Address(RVA = "0x22A81F8", Offset = "0x22A81F8", VA = "0x22A81F8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C83C")]
	[Address(RVA = "0x22A7BF0", Offset = "0x22A7BF0", VA = "0x22A7BF0")]
	private void RefreshComboShow()
	{
	}

	[Token(Token = "0x600C83D")]
	[Address(RVA = "0x22A79B8", Offset = "0x22A79B8", VA = "0x22A79B8")]
	private void InitToneConfigList()
	{
	}

	[Token(Token = "0x600C83E")]
	[Address(RVA = "0x22A8570", Offset = "0x22A8570", VA = "0x22A8570")]
	private void Update()
	{
	}

	[Token(Token = "0x600C83F")]
	[Address(RVA = "0x22A860C", Offset = "0x22A860C", VA = "0x22A860C")]
	private void CheckToneCreate()
	{
	}

	[Token(Token = "0x600C840")]
	[Address(RVA = "0x22A883C", Offset = "0x22A883C", VA = "0x22A883C")]
	private void CreateTone(SingerMiniMusicGamePhaseThreeConfigData conf)
	{
	}

	[Token(Token = "0x600C841")]
	[Address(RVA = "0x22A8C24", Offset = "0x22A8C24", VA = "0x22A8C24")]
	private Vector3 GetToneRandomPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600C842")]
	[Address(RVA = "0x22A9084", Offset = "0x22A9084", VA = "0x22A9084")]
	private void OnToneFinish(object[] data)
	{
	}

	[Token(Token = "0x600C844")]
	[Address(RVA = "0x22A95E0", Offset = "0x22A95E0", VA = "0x22A95E0")]
	private static int _003CInitToneConfigList_003Em__0(SingerMiniMusicGamePhaseThreeConfigData a, SingerMiniMusicGamePhaseThreeConfigData b)
	{
		return default(int);
	}

	[Token(Token = "0x600C845")]
	[Address(RVA = "0x22A9634", Offset = "0x22A9634", VA = "0x22A9634")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C846")]
	[Address(RVA = "0x22A963C", Offset = "0x22A963C", VA = "0x22A963C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C847")]
	[Address(RVA = "0x22A9644", Offset = "0x22A9644", VA = "0x22A9644")]
	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600C848")]
	[Address(RVA = "0x22A964C", Offset = "0x22A964C", VA = "0x22A964C")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}

	[Token(Token = "0x600C849")]
	[Address(RVA = "0x22A9654", Offset = "0x22A9654", VA = "0x22A9654")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
