using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004153")]
public class UIMenu : MonoBehaviour
{
	[Token(Token = "0x2004154")]
	public enum Pivot
	{
		[Token(Token = "0x401B69E")]
		HorizontalCenter,
		[Token(Token = "0x401B69F")]
		RightToLeft,
		[Token(Token = "0x401B6A0")]
		LeftToRight,
		[Token(Token = "0x401B6A1")]
		TopToBottom
	}

	[Token(Token = "0x2004155")]
	private sealed class _003CTrySelectByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B6A2")]
		[FieldOffset(Offset = "0x8")]
		internal string id;

		[Token(Token = "0x601AB0E")]
		[Address(RVA = "0x2CA72F4", Offset = "0x2CA72F4", VA = "0x2CA72F4")]
		public _003CTrySelectByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601AB0F")]
		[Address(RVA = "0x2CA7AC4", Offset = "0x2CA7AC4", VA = "0x2CA7AC4")]
		internal bool _003C_003Em__0(UIMenuItem e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2004156")]
	private sealed class _003CFindMenuItemByID_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B6A3")]
		[FieldOffset(Offset = "0x8")]
		internal string id;

		[Token(Token = "0x601AB10")]
		[Address(RVA = "0x2CA74CC", Offset = "0x2CA74CC", VA = "0x2CA74CC")]
		public _003CFindMenuItemByID_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601AB11")]
		[Address(RVA = "0x2CA7990", Offset = "0x2CA7990", VA = "0x2CA7990")]
		internal bool _003C_003Em__0(UIMenuItem e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B697")]
	[FieldOffset(Offset = "0xC")]
	public UIMenuItem menuTemplate;

	[Token(Token = "0x401B698")]
	[FieldOffset(Offset = "0x10")]
	public Pivot pivot;

	[Token(Token = "0x401B699")]
	[FieldOffset(Offset = "0x14")]
	public float space;

	[Token(Token = "0x401B69A")]
	[FieldOffset(Offset = "0x18")]
	public bool exActiveAsClick;

	[Token(Token = "0x401B69B")]
	[FieldOffset(Offset = "0x1C")]
	private List<UIMenuItem> m_Menus;

	[Token(Token = "0x401B69C")]
	[FieldOffset(Offset = "0x20")]
	private UIMenuItem m_SelectedMenu;

	[Token(Token = "0x601AB00")]
	[Address(RVA = "0x2CA661C", Offset = "0x2CA661C", VA = "0x2CA661C")]
	public UIMenu()
	{
	}

	[Token(Token = "0x601AB01")]
	[Address(RVA = "0x2CA66A8", Offset = "0x2CA66A8", VA = "0x2CA66A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AB02")]
	[Address(RVA = "0x2CA677C", Offset = "0x2CA677C", VA = "0x2CA677C")]
	private void Start()
	{
	}

	[Token(Token = "0x601AB03")]
	[Address(RVA = "0x2CA6780", Offset = "0x2CA6780", VA = "0x2CA6780")]
	private void Update()
	{
	}

	[Token(Token = "0x601AB04")]
	[Address(RVA = "0x2CA6784", Offset = "0x2CA6784", VA = "0x2CA6784")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601AB05")]
	[Address(RVA = "0x2CA68A8", Offset = "0x2CA68A8", VA = "0x2CA68A8")]
	public void AddMenu(UIMenuItemData menuData)
	{
	}

	[Token(Token = "0x601AB06")]
	[Address(RVA = "0x2CA6CF4", Offset = "0x2CA6CF4", VA = "0x2CA6CF4")]
	public void Build(string selectID = "")
	{
	}

	[Token(Token = "0x601AB07")]
	[Address(RVA = "0x2CA7174", Offset = "0x2CA7174", VA = "0x2CA7174")]
	public void TrySelectByID(string id)
	{
	}

	[Token(Token = "0x601AB08")]
	[Address(RVA = "0x2CA73D4", Offset = "0x2CA73D4", VA = "0x2CA73D4")]
	public UIMenuItem FindMenuItemByID(string id)
	{
		return null;
	}

	[Token(Token = "0x601AB09")]
	[Address(RVA = "0x2CA74D4", Offset = "0x2CA74D4", VA = "0x2CA74D4")]
	public void Clear()
	{
	}

	[Token(Token = "0x601AB0A")]
	[Address(RVA = "0x2CA6D18", Offset = "0x2CA6D18", VA = "0x2CA6D18")]
	public void Reposion()
	{
	}

	[Token(Token = "0x601AB0B")]
	[Address(RVA = "0x2CA72FC", Offset = "0x2CA72FC", VA = "0x2CA72FC")]
	private void OnMenuSelected(UIMenuItem selectMenu)
	{
	}

	[Token(Token = "0x601AB0C")]
	[Address(RVA = "0x2CA78E4", Offset = "0x2CA78E4", VA = "0x2CA78E4")]
	public static Vector3 LocalPositionSetY(Transform target, float y)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AB0D")]
	[Address(RVA = "0x2CA7838", Offset = "0x2CA7838", VA = "0x2CA7838")]
	public static Vector3 LocalPositionSetX(Transform target, float x)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
