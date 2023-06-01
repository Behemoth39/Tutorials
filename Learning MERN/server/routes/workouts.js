const express = require("express");

const {
  getWorkouts,
  getWorkout,
  postWorkout,
  deleteWorkout,
  patchWorkout,
} = require("../Controllers/workoutController");

const router = express.Router();

router.get("/", getWorkouts);

router.get("/:id", getWorkout);

router.post("/", postWorkout);

router.delete("/:id", deleteWorkout);

router.patch("/:id", patchWorkout);

module.exports = router;
