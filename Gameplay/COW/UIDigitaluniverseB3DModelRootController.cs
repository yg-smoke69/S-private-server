using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x2001EA2")]
public class UIDigitaluniverseB3DModelRootController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2001EA3")]
	public struct ModelItemStruct
	{
		[Token(Token = "0x400C0A1")]
		[FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x400C0A2")]
		[FieldOffset(Offset = "0x4")]
		public UIDigitaluniverseB3DModelItemController modelItemCtrl;
	}

	[Token(Token = "0x400C08A")]
	[FieldOffset(Offset = "0xC")]
	private readonly string MouseHorizontalAxisName;

	[Token(Token = "0x400C08B")]
	[FieldOffset(Offset = "0x10")]
	private float m_PowerMouseHorizontal;

	[Token(Token = "0x400C08C")]
	private const uint BGHEIGHT = 1024u;

	[Token(Token = "0x400C08D")]
	private const uint BGWITH = 512u;

	[Token(Token = "0x400C08E")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 m_LastMousePosition;

	[Token(Token = "0x400C08F")]
	[FieldOffset(Offset = "0x20")]
	public float PowerWithDrag;

	[Token(Token = "0x400C090")]
	[FieldOffset(Offset = "0x24")]
	public float PowerWithoutDrag;

	[Token(Token = "0x400C091")]
	[FieldOffset(Offset = "0x28")]
	public float PowerInGuideWithoutDrag;

	[Token(Token = "0x400C092")]
	[FieldOffset(Offset = "0x2C")]
	public float RotateSensitivity;

	[Token(Token = "0x400C093")]
	[FieldOffset(Offset = "0x30")]
	public Transform Centralaxis;

	[Token(Token = "0x400C094")]
	[FieldOffset(Offset = "0x34")]
	public Transform CoreAward;

	[Token(Token = "0x400C095")]
	[FieldOffset(Offset = "0x38")]
	public float PressInterval;

	[Token(Token = "0x400C096")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CurrentPanAngle;

	[Token(Token = "0x400C097")]
	[FieldOffset(Offset = "0x40")]
	private bool m_FirstPress;

	[Token(Token = "0x400C098")]
	[FieldOffset(Offset = "0x44")]
	private float m_LastPressTime;

	[Token(Token = "0x400C099")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasPlayingMusic;

	[Token(Token = "0x400C09A")]
	[FieldOffset(Offset = "0x49")]
	private bool m_PlayerFirstRotateLog;

	[Token(Token = "0x400C09B")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C09C")]
	[FieldOffset(Offset = "0x50")]
	public List<Transform> BG;

	[Token(Token = "0x400C09D")]
	[FieldOffset(Offset = "0x54")]
	public Animation DigitaluniverseB3DRoot;

	[Token(Token = "0x400C09E")]
	[FieldOffset(Offset = "0x58")]
	public ModelItemStruct Core;

	[Token(Token = "0x400C09F")]
	[FieldOffset(Offset = "0x60")]
	public List<Transform> m_DoorItemList;

	[Token(Token = "0x400C0A0")]
	[FieldOffset(Offset = "0x64")]
	public ModelItemStruct[] modelItems;

	[Token(Token = "0x60093E2")]
	[Address(RVA = "0x2D8A410", Offset = "0x2D8A410", VA = "0x2D8A410")]
	public UIDigitaluniverseB3DModelRootController()
	{
	}

	[Token(Token = "0x60093E3")]
	[Address(RVA = "0x2D8A4E8", Offset = "0x2D8A4E8", VA = "0x2D8A4E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60093E4")]
	[Address(RVA = "0x2D8A5EC", Offset = "0x2D8A5EC", VA = "0x2D8A5EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60093E5")]
	[Address(RVA = "0x2D8A668", Offset = "0x2D8A668", VA = "0x2D8A668")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60093E6")]
	[Address(RVA = "0x2D8A740", Offset = "0x2D8A740", VA = "0x2D8A740")]
	public void SetBgScale(int height, int with)
	{
	}

	[Token(Token = "0x60093E7")]
	[Address(RVA = "0x2D8A8F0", Offset = "0x2D8A8F0", VA = "0x2D8A8F0")]
	public void SetDoorState(string key, DoorState state, bool show)
	{
	}

	[Token(Token = "0x60093E8")]
	[Address(RVA = "0x2D8AAF8", Offset = "0x2D8AAF8", VA = "0x2D8AAF8")]
	public void SetColliderState(bool show)
	{
	}

	[Token(Token = "0x60093E9")]
	[Address(RVA = "0x2D8ABD4", Offset = "0x2D8ABD4", VA = "0x2D8ABD4")]
	public void SetDoorRedPointState(string key, bool show)
	{
	}

	[Token(Token = "0x60093EA")]
	[Address(RVA = "0x2D8AD80", Offset = "0x2D8AD80", VA = "0x2D8AD80")]
	public void SetCoreState(uint num)
	{
	}

	[Token(Token = "0x60093EB")]
	[Address(RVA = "0x2D8AE84", Offset = "0x2D8AE84", VA = "0x2D8AE84")]
	public float PlayAniamtion(string anim)
	{
		return default(float);
	}

	[Token(Token = "0x60093EC")]
	[Address(RVA = "0x2D8B01C", Offset = "0x2D8B01C", VA = "0x2D8B01C")]
	private void Update()
	{
	}

	[Token(Token = "0x60093ED")]
	[Address(RVA = "0x2D8B588", Offset = "0x2D8B588", VA = "0x2D8B588")]
	private void RotateAvatar(float angle, float angledelta = 0f)
	{
	}
}
