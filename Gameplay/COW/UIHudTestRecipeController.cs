using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002872")]
public class UIHudTestRecipeController : UIBaseController
{
	[Token(Token = "0x2002873")]
	public enum EUseQuality
	{
		[Token(Token = "0x400F95B")]
		Default,
		[Token(Token = "0x400F95C")]
		Low,
		[Token(Token = "0x400F95D")]
		High
	}

	[Token(Token = "0x2002874")]
	private sealed class _003CInitAvatarGrid_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F95E")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSSharedAvatarData> _003CallData_003E__0;

		[Token(Token = "0x400F95F")]
		[FieldOffset(Offset = "0xC")]
		internal List<CSSharedAvatarData>.Enumerator _0024locvar0;

		[Token(Token = "0x400F960")]
		[FieldOffset(Offset = "0x1C")]
		internal UIHudTestRecipeController _0024this;

		[Token(Token = "0x400F961")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400F962")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400F963")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x400F964")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<Transform> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x170011F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FDB4")]
			[Address(RVA = "0x17B4C5C", Offset = "0x17B4C5C", VA = "0x17B4C5C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FDB5")]
			[Address(RVA = "0x17B4C64", Offset = "0x17B4C64", VA = "0x17B4C64", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FDB2")]
		[Address(RVA = "0x17B28C0", Offset = "0x17B28C0", VA = "0x17B28C0")]
		public _003CInitAvatarGrid_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600FDB3")]
		[Address(RVA = "0x17B44E8", Offset = "0x17B44E8", VA = "0x17B44E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FDB6")]
		[Address(RVA = "0x17B4C6C", Offset = "0x17B4C6C", VA = "0x17B4C6C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FDB7")]
		[Address(RVA = "0x17B4C80", Offset = "0x17B4C80", VA = "0x17B4C80", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600FDB8")]
		[Address(RVA = "0x17B4D08", Offset = "0x17B4D08", VA = "0x17B4D08")]
		private static int _003C_003Em__0(Transform transform1, Transform transform2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400F952")]
	[FieldOffset(Offset = "0x28")]
	public UIHudTestRecipeView m_View;

	[Token(Token = "0x400F953")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsFemale;

	[Token(Token = "0x400F954")]
	[FieldOffset(Offset = "0x30")]
	public UIHudTestRecipeEasyList RecipeEasyListCallback;

	[Token(Token = "0x400F955")]
	[FieldOffset(Offset = "0x34")]
	public UIHudTestRecipeEasyList SearchEasyListCallback;

	[Token(Token = "0x400F956")]
	[FieldOffset(Offset = "0x38")]
	public uint AvatarID;

	[Token(Token = "0x400F957")]
	[FieldOffset(Offset = "0x3C")]
	public Dictionary<int, AvatarWardrobeData> SelectedRecipeIndexMap;

	[Token(Token = "0x400F958")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<string, AvatarWardrobeData> m_IndexToWdDic;

	[Token(Token = "0x400F959")]
	[FieldOffset(Offset = "0x44")]
	private int LastWardrobeType;

	[Token(Token = "0x600FD9D")]
	[Address(RVA = "0x17B1558", Offset = "0x17B1558", VA = "0x17B1558")]
	public UIHudTestRecipeController()
	{
	}

	[Token(Token = "0x600FD9E")]
	[Address(RVA = "0x17B164C", Offset = "0x17B164C", VA = "0x17B164C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD9F")]
	[Address(RVA = "0x17B16F4", Offset = "0x17B16F4", VA = "0x17B16F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDA0")]
	[Address(RVA = "0x17B2568", Offset = "0x17B2568", VA = "0x17B2568", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FDA1")]
	[Address(RVA = "0x17B269C", Offset = "0x17B269C", VA = "0x17B269C")]
	private void OnBroadcastToOthers()
	{
	}

	[Token(Token = "0x600FDA2")]
	[Address(RVA = "0x17B1E28", Offset = "0x17B1E28", VA = "0x17B1E28")]
	private IEnumerator InitAvatarGrid()
	{
		return null;
	}

	[Token(Token = "0x600FDA3")]
	[Address(RVA = "0x17B28C8", Offset = "0x17B28C8", VA = "0x17B28C8")]
	private void InitSearchIndex()
	{
	}

	[Token(Token = "0x600FDA4")]
	[Address(RVA = "0x17B1EF4", Offset = "0x17B1EF4", VA = "0x17B1EF4")]
	private void InitWardrobeTypeGrid()
	{
	}

	[Token(Token = "0x600FDA5")]
	[Address(RVA = "0x17B2E88", Offset = "0x17B2E88", VA = "0x17B2E88")]
	private void OnDeubgToggle()
	{
	}

	[Token(Token = "0x600FDA6")]
	[Address(RVA = "0x17B2F58", Offset = "0x17B2F58", VA = "0x17B2F58")]
	private void OnClearAllClicked()
	{
	}

	[Token(Token = "0x600FDA7")]
	[Address(RVA = "0x17B3B18", Offset = "0x17B3B18", VA = "0x17B3B18")]
	private void ClearAllSlots()
	{
	}

	[Token(Token = "0x600FDA8")]
	[Address(RVA = "0x17B223C", Offset = "0x17B223C", VA = "0x17B223C")]
	private void OnUseDefaultQualityCheckBoxClicked()
	{
	}

	[Token(Token = "0x600FDA9")]
	[Address(RVA = "0x17B401C", Offset = "0x17B401C", VA = "0x17B401C")]
	private void OnUseHighQualityCheckBoxClicked()
	{
	}

	[Token(Token = "0x600FDAA")]
	[Address(RVA = "0x17B3C64", Offset = "0x17B3C64", VA = "0x17B3C64")]
	private void OnQualityChanged()
	{
	}

	[Token(Token = "0x600FDAB")]
	[Address(RVA = "0x17B3628", Offset = "0x17B3628", VA = "0x17B3628")]
	private void OnSearchInputChanged()
	{
	}

	[Token(Token = "0x600FDAC")]
	[Address(RVA = "0x17B4154", Offset = "0x17B4154", VA = "0x17B4154")]
	private void OnAvatarBtnClicked(CSSharedAvatarData data)
	{
	}

	[Token(Token = "0x600FDAD")]
	[Address(RVA = "0x17B310C", Offset = "0x17B310C", VA = "0x17B310C")]
	public void OnWardrobeTypeClicked(int wt)
	{
	}

	[Token(Token = "0x600FDAE")]
	[Address(RVA = "0x17B42F0", Offset = "0x17B42F0", VA = "0x17B42F0")]
	public void OnRecipeBtnClicked(UIHudTestRecipeRecipeBtn btn, AvatarWardrobeData wdata, bool isSearch)
	{
	}

	[Token(Token = "0x600FDAF")]
	[Address(RVA = "0x17B2448", Offset = "0x17B2448", VA = "0x17B2448")]
	private void OnShowDebugUI(object[] param)
	{
	}

	[Token(Token = "0x600FDB0")]
	[Address(RVA = "0x17B44D8", Offset = "0x17B44D8", VA = "0x17B44D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FDB1")]
	[Address(RVA = "0x17B44E0", Offset = "0x17B44E0", VA = "0x17B44E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
