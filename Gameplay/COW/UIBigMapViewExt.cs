using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A99")]
internal class UIBigMapViewExt : UIBigMapView
{
	[Token(Token = "0x4018EC1")]
	[FieldOffset(Offset = "0x110")]
	private float MAP_SIZE_HEIGHT;

	[Token(Token = "0x4018EC2")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 m_MapLocalScale;

	[Token(Token = "0x170016DA")]
	public Vector3 MinMapLocalScale
	{
		[Token(Token = "0x6017385")]
		[Address(RVA = "0x10C4A84", Offset = "0x10C4A84", VA = "0x10C4A84")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x6017384")]
	[Address(RVA = "0x10D4448", Offset = "0x10D4448", VA = "0x10D4448")]
	public UIBigMapViewExt()
	{
	}

	[Token(Token = "0x6017386")]
	[Address(RVA = "0x10D4470", Offset = "0x10D4470", VA = "0x10D4470", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017387")]
	[Address(RVA = "0x10C48EC", Offset = "0x10C48EC", VA = "0x10C48EC")]
	public void RefreshScale()
	{
	}

	[Token(Token = "0x6017388")]
	[Address(RVA = "0x10D469C", Offset = "0x10D469C", VA = "0x10D469C")]
	public new void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
