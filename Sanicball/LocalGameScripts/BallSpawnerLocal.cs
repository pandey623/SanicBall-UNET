﻿using UnityEngine;

namespace Sanicball
{
    public abstract class BallSpawnerLocal : MonoBehaviour
    {
        [SerializeField]
        private Ball ballPrefab = null;

        protected Ball SpawnBall(Vector3 position, Quaternion rotation, BallType ballType, ControlType ctrlType, int character, string nickname)
        {
            var ball = (Ball)Instantiate(ballPrefab, position, rotation);
            ball.Init(ballType, ctrlType, character, nickname);

            return ball;
        }
    }
}