using System;
using Character_Controller;
using Interaction;
using TiltFive;
using UnityEngine;

namespace Ship
{
	public class Player : MonoBehaviour
	{
		public Color playerUIColor;

		private RBCharacterController _characterController;
		private PlayerInteractionHandler _playerInteractionHandler;
		public CharacterControllerInput Input => _input;
		public PlayerIndex PlayerIndex => Input.TiltPlayerIndex;//should we own this?

		private CharacterControllerInput _input;
		
		public GameObject playerOne;
		public GameObject playerTwo;
		public GameObject playerThree;
		public GameObject playerFour;

		private void Awake()
		{
			_playerInteractionHandler = GetComponent<PlayerInteractionHandler>();
			_characterController = GetComponent<RBCharacterController>();
			_input = GetComponent<CharacterControllerInput>();

			if (_playerInteractionHandler != null)
			{
				_playerInteractionHandler.SetPlayer(this);
			}
			
			_input.SetPlayer(this);

			
		}

		private void Start()
		{
			if (PlayerIndex == PlayerIndex.One)
			{
				playerOne.SetActive(true);
				playerTwo.SetActive(false);
				playerThree.SetActive(false);
				playerFour.SetActive(false);
			}
			else if (PlayerIndex == PlayerIndex.Two)
			{
				playerOne.SetActive(false);
				playerTwo.SetActive(true);
				playerThree.SetActive(false);
				playerFour.SetActive(false);
			}
			else if (PlayerIndex == PlayerIndex.Three)
			{
				playerOne.SetActive(false);
				playerTwo.SetActive(false);
				playerThree.SetActive(true);
				playerFour.SetActive(false);
			}
			else if (PlayerIndex == PlayerIndex.Four)
			{
				playerOne.SetActive(false);
				playerTwo.SetActive(false);
				playerThree.SetActive(false);
				playerFour.SetActive(true);
			}
		}
	}
}