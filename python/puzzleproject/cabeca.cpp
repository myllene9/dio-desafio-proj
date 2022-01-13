#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <vector>

using namespace cv;
using namespace std;

void highlightPiece(Mat &completo, Mat &peca) {
	vector<Point> refs;

	int quantPontos = 10;

	for (int i = 0; i < quantPontos; i++) {
		Point p;
		p.x = rand() % peca.cols;
		p.y = rand() % peca.rows;

		Vec3b pixel = peca.at<Vec3b>(p.y, p.x);
		if (pixel.val[0] == 255 && pixel.val[1] == 255 && pixel.val[2] == 255) {
			i--;
		}
		else {
			refs.push_back(p);
		}

	}

	/*for (int i = 0; i < quantPontos; i++) {
	circle(peca, refs[i], 2, Scalar(255, 0, 0), -1);
	}*/

	float minDiff = 999999999999;
	int rx = -1;
	int ry = -1;

	for (int i = 0; i < completo.rows - peca.rows; i++) {
		for (int j = 0; j < completo.cols - peca.cols; j++) {
			float diff = 0;
			for (int k = 0; k < quantPontos; k++) {
				Vec3b pixelpeca = peca.at<Vec3b>(refs[k].y, refs[k].x);
				Vec3b pixelcompleto = completo.at<Vec3b>(i + refs[k].y, j + refs[k].x);

				diff += (pixelpeca.val[0] - pixelcompleto.val[0])*(pixelpeca.val[0] - pixelcompleto.val[0])
					+ (pixelpeca.val[1] - pixelcompleto.val[1])*(pixelpeca.val[1] - pixelcompleto.val[1]) +
					(pixelpeca.val[2] - pixelcompleto.val[2])*(pixelpeca.val[2] - pixelcompleto.val[2]);
			}
			//printf("%f\n", diff);
			if (diff < minDiff) {
				minDiff = diff;
				rx = j;
				ry = i;
			}
		}
	}

	printf("%d %d\n", rx, ry);

	rectangle(completo, Rect(rx, ry, peca.cols, peca.rows), Scalar(0, 0, 255), 2);

}


void main() {

	Mat completo = imread("completo.jpg", 1);
	Mat peca = imread("peca1.jpg", 1);
	highlightPiece(completo, peca);

	peca = imread("peca2.jpg", 1);
	highlightPiece(completo, peca);

	peca = imread("peca8.jpg", 1);
	highlightPiece(completo, peca);

	peca = imread("peca9.jpg", 1);
	highlightPiece(completo, peca);
		
	imshow("completo", completo);
	waitKey(0);
}