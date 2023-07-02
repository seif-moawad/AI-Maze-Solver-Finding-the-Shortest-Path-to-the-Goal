# AI Maze Solver: Finding the Shortest Path to the Goal

Welcome to our AI Maze Solver! This powerful tool is designed to tackle various mazes and find the shortest path from a designated start node to a goal node. By employing state-of-the-art algorithms like Greedy, A*, and Uniform Cost Search, our AI agent ensures efficient and optimal pathfinding. Let's explore the key features and functionalities of this project.

## Features

### Maze Selection
Users can select a maze of their choice from the available options. Each maze comes with a designated start node and a goal node. The agent will navigate from the start node to the goal node, finding the shortest path along the way.

### Greedy Search
The AI agent uses the Greedy Search algorithm to explore the maze. Greedy Search prioritizes exploring nodes that seem to be closer to the goal based on a heuristic function. While not guaranteed to find the shortest path, it often provides quick results.

### A* Search
For more precise and optimal results, users can choose the A* Search algorithm. A* combines the actual cost of reaching a node (path cost) with an admissible heuristic function that estimates the cost from the node to the goal. This combination ensures that the AI agent explores the most promising paths first and eventually finds the shortest path.

### Uniform Cost Search
For mazes where all edges have equal costs, users can opt for Uniform Cost Search. This algorithm systematically explores all possible paths, guaranteeing the discovery of the shortest path from the start node to the goal.

### Path Calculation and Cost Evaluation
Once the AI agent successfully solves the maze, it calculates the cost of the taken path. Users can view the total cost incurred in reaching the goal from the start node, which can be helpful for further analysis and comparison.

### Path Highlighting
To enhance user experience, the selected path from the start node to the goal is visually highlighted on the maze. This feature provides a clear visualization of the route chosen by the AI agent.
