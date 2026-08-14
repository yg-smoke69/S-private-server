using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003547")]
public class UIFriendRelationshipGraphView : UIBaseView
{
	[Token(Token = "0x40151A6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject VFX_RelationShip_CloseFriend;

	[Token(Token = "0x40151A7")]
	[FieldOffset(Offset = "0x18")]
	public UIFriendRelationshipGraphContainer SelfItem;

	[Token(Token = "0x40151A8")]
	[FieldOffset(Offset = "0x1C")]
	public UIFriendRelationshipGraphContainer CloseFriend_1;

	[Token(Token = "0x40151A9")]
	[FieldOffset(Offset = "0x20")]
	public UIFriendRelationshipGraphContainer BLayerFriend_1;

	[Token(Token = "0x40151AA")]
	[FieldOffset(Offset = "0x24")]
	public UIFriendRelationshipGraphContainer BLayerFriend_2;

	[Token(Token = "0x40151AB")]
	[FieldOffset(Offset = "0x28")]
	public UIFriendRelationshipGraphContainer BLayerFriend_3;

	[Token(Token = "0x40151AC")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CLayer;

	[Token(Token = "0x40151AD")]
	[FieldOffset(Offset = "0x30")]
	public UIFriendRelationshipGraphContainer CLayerFriend_1;

	[Token(Token = "0x40151AE")]
	[FieldOffset(Offset = "0x34")]
	public UIFriendRelationshipGraphContainer CLayerFriend_2;

	[Token(Token = "0x40151AF")]
	[FieldOffset(Offset = "0x38")]
	public UIFriendRelationshipGraphContainer CLayerFriend_3;

	[Token(Token = "0x40151B0")]
	[FieldOffset(Offset = "0x3C")]
	public UIFriendRelationshipGraphContainer CLayerFriend_4;

	[Token(Token = "0x40151B1")]
	[FieldOffset(Offset = "0x40")]
	public UIFriendRelationshipGraphContainer CLayerFriend_5;

	[Token(Token = "0x40151B2")]
	[FieldOffset(Offset = "0x44")]
	public UIFriendRelationshipGraphContainer DLayerFriend_1;

	[Token(Token = "0x40151B3")]
	[FieldOffset(Offset = "0x48")]
	public UIFriendRelationshipGraphContainer DLayerFriend_2;

	[Token(Token = "0x40151B4")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton shareBtn;

	[Token(Token = "0x6016385")]
	[Address(RVA = "0x250E2D0", Offset = "0x250E2D0", VA = "0x250E2D0")]
	public UIFriendRelationshipGraphView()
	{
	}

	[Token(Token = "0x6016386")]
	[Address(RVA = "0x250E2D8", Offset = "0x250E2D8", VA = "0x250E2D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016387")]
	[Address(RVA = "0x250E9A8", Offset = "0x250E9A8", VA = "0x250E9A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
