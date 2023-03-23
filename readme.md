## About The Project
First assignement of the C# development class in Fachhochschule St. Poelten. Implementation of the algorithms Merge and Bubble sort.


### Built With

Visual Studio Code
.Net 6 SDKs


<!-- GETTING STARTED -->
### Prerequisites

Before running or working with this project, ensure that you have the following software and tools installed on your system:

Visual Studio Code: https://code.visualstudio.com/download
.NET 6.0 SDK: https://dotnet.microsoft.com/download/dotnet/6.0
Make sure that you have correctly installed the .NET 6.0 SDK and have configured your environment variables to use the correct version of .NET. You can verify your installation and version of .NET by running the following command in your terminal:
* dotnet
  ```sh
  dotnet --version
  ```

If the above command returns the version of .NET that you installed, you're ready to use this project. If not, please refer to the documentation provided by Microsoft to correctly install and configure .NET 6.0.

### Installation

1. Download and extract the source file (.zip file), open it in your coding editor
2. In the terminal, change the directory to the provided source code
3. Run it with the command sort -Bubble/-Merge -int/-double/-string “1,4,2,3” or sort -Bubble/-Merge -int/-double/-string 1 4 2 3"


<!-- USAGE EXAMPLES -->
## Usage

The usage of this code is to sort a list of numbers with the chosen algorithm - either bubble sort or merge sort. The user can input any list of integers and they will be sorted. To have a correct output (sorted integers), please input the numbers only as the following example: 


The program handles misuage by providing the correct formating for the input.
dotnet run sort -Bubble "3, 12, 48, 22, 33, 1254"  if you want to use the Bubble sort algorithm
or 
dotnet run sort -Merge "2, 34, 5, 12, 33, 40" if you want to use the Merge sort algorithm

The number of integers may vary, but the program cannot handle any exceptions when it comes to the input format except for mistyping the type of sorting algorithm. Always separate the numbers with comma.

The output may look like this: 
This is your sorted array: 
2 5 12 33 40


<!-- ROADMAP -->
## Roadmap

### Potential future improvements
The list of the potential future improvements is already prioritized as written in the points.
- Ensure that the input from the user is an integer 
- Check whether there are more than 1 number inserted, if not, stop the program. 
- Find more efficient solutions
- Add support for additional input types, such as CSV and JSON files
- Develop user interface

This is a tentative roadmap and subject to change based on feedback and contributions from the community.


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please open an issue with the tag "enhancement".

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


<!-- LICENSE -->
## License

Distributed under the MIT License.


<!-- CONTACT -->
## Contact

Alica Holla, 
e-mail: cc211034@fhstp.ac.at

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [wikipedia](https://en.wikipedia.org/wiki/Bubble_sort)
* [GeeksforGeeks](https://www.geeksforgeeks.org/merge-sort/)
* [StackOverflow](https://stackoverflow.com/)
* [OpenAI] (https://chat.openai.com/chat)