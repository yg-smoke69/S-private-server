using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A40")]
public class PreviewStoryCgShowUIComp : UIBaseController
{
	[Token(Token = "0x2000A41")]
	private sealed class _003CSetSharePreviewPos_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005B7E")]
		[FieldOffset(Offset = "0x8")]
		internal UIImageSharePreviewWindowController _003Cctrl_003E__0;

		[Token(Token = "0x4005B7F")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Clayer_003E__0;

		[Token(Token = "0x4005B80")]
		[FieldOffset(Offset = "0x10")]
		internal PreviewStoryCgShowUIComp _0024this;

		[Token(Token = "0x4005B81")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4005B82")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x4005B83")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000630")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004FD6")]
			[Address(RVA = "0x1962C48", Offset = "0x1962C48", VA = "0x1962C48", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000631")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004FD7")]
			[Address(RVA = "0x1962C50", Offset = "0x1962C50", VA = "0x1962C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x1962598", Offset = "0x1962598", VA = "0x1962598")]
		public _003CSetSharePreviewPos_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x1962978", Offset = "0x1962978", VA = "0x1962978", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FD8")]
		[Address(RVA = "0x1962C58", Offset = "0x1962C58", VA = "0x1962C58", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x1962C6C", Offset = "0x1962C6C", VA = "0x1962C6C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005B70")]
	[FieldOffset(Offset = "0x28")]
	private PreviewStoryCgComp m_StoryCgInstance;

	[Token(Token = "0x4005B71")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton m_Sharebtn;

	[Token(Token = "0x4005B72")]
	[FieldOffset(Offset = "0x30")]
	public UIButton m_Replaybtn;

	[Token(Token = "0x4005B73")]
	[FieldOffset(Offset = "0x34")]
	public UIButton m_Funcbtn;

	[Token(Token = "0x4005B74")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_BgTex;

	[Token(Token = "0x4005B75")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel m_FunTxt;

	[Token(Token = "0x4005B76")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isLevelup;

	[Token(Token = "0x4005B77")]
	[FieldOffset(Offset = "0x41")]
	private bool m_ShowFuncBtn;

	[Token(Token = "0x4005B78")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Eppanel;

	[Token(Token = "0x4005B79")]
	[FieldOffset(Offset = "0x48")]
	public GameObject MallPanel;

	[Token(Token = "0x4005B7A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GachaPanel;

	[Token(Token = "0x4005B7B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel Subtitle;

	[Token(Token = "0x4005B7C")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ContinueLabel;

	[Token(Token = "0x4005B7D")]
	[FieldOffset(Offset = "0x58")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x6004FBF")]
	[Address(RVA = "0x196178C", Offset = "0x196178C", VA = "0x196178C")]
	public PreviewStoryCgShowUIComp()
	{
	}

	[Token(Token = "0x6004FC0")]
	[Address(RVA = "0x1960244", Offset = "0x1960244", VA = "0x1960244")]
	public void SetStoryCGInstance(PreviewStoryCgComp ins)
	{
	}

	[Token(Token = "0x6004FC1")]
	[Address(RVA = "0x1961818", Offset = "0x1961818", VA = "0x1961818")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6004FC2")]
	[Address(RVA = "0x19602A4", Offset = "0x19602A4", VA = "0x19602A4")]
	public void InitShowUI(bool isHas, bool showFuncBtn = true)
	{
	}

	[Token(Token = "0x6004FC3")]
	[Address(RVA = "0x1960C18", Offset = "0x1960C18", VA = "0x1960C18")]
	public void PlaySubtitle(string subtitleStr)
	{
	}

	[Token(Token = "0x6004FC4")]
	[Address(RVA = "0x1960DA4", Offset = "0x1960DA4", VA = "0x1960DA4")]
	public void StopSubtitle()
	{
	}

	[Token(Token = "0x6004FC5")]
	[Address(RVA = "0x1961878", Offset = "0x1961878", VA = "0x1961878")]
	public void ShowContinueLabel()
	{
	}

	[Token(Token = "0x6004FC6")]
	[Address(RVA = "0x1961914", Offset = "0x1961914", VA = "0x1961914")]
	protected bool CheckItemListIsBuy(List<uint> itemlist)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FC7")]
	[Address(RVA = "0x1961A64", Offset = "0x1961A64", VA = "0x1961A64")]
	protected bool CheckItemIsBuy(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FC8")]
	[Address(RVA = "0x1961C1C", Offset = "0x1961C1C", VA = "0x1961C1C", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6004FC9")]
	[Address(RVA = "0x1961EA4", Offset = "0x1961EA4", VA = "0x1961EA4")]
	private void Set3DModelVisiable(bool b)
	{
	}

	[Token(Token = "0x6004FCA")]
	[Address(RVA = "0x1961FA8", Offset = "0x1961FA8", VA = "0x1961FA8")]
	private void OnbtnShare()
	{
	}

	[Token(Token = "0x6004FCB")]
	[Address(RVA = "0x19621E4", Offset = "0x19621E4", VA = "0x19621E4", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6004FCC")]
	[Address(RVA = "0x19623B8", Offset = "0x19623B8", VA = "0x19623B8", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6004FCD")]
	[Address(RVA = "0x1962118", Offset = "0x1962118", VA = "0x1962118")]
	private IEnumerator SetSharePreviewPos()
	{
		return null;
	}

	[Token(Token = "0x6004FCE")]
	[Address(RVA = "0x19625A0", Offset = "0x19625A0", VA = "0x19625A0")]
	private void OnbtnReplay()
	{
	}

	[Token(Token = "0x6004FCF")]
	[Address(RVA = "0x1962698", Offset = "0x1962698", VA = "0x1962698")]
	private void ClearStoryCG()
	{
	}

	[Token(Token = "0x6004FD0")]
	[Address(RVA = "0x1962790", Offset = "0x1962790", VA = "0x1962790")]
	private void OnbtnFunc()
	{
	}

	[Token(Token = "0x6004FD1")]
	[Address(RVA = "0x1962960", Offset = "0x1962960", VA = "0x1962960")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x6004FD2")]
	[Address(RVA = "0x1962968", Offset = "0x1962968", VA = "0x1962968")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6004FD3")]
	[Address(RVA = "0x1962970", Offset = "0x1962970", VA = "0x1962970")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
